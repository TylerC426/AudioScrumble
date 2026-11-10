using System;
using System.Drawing;
using NWaves.Signals;
using NWaves.Transforms;

namespace MediocreSoundDesigner;

public class SpectrogramRenderer //: IDisposable
{
    // constants
    private const int WindowSize = 1024;    // num audio samples analyzed at a given time
    private const int HopSize = 512;        // num samples to move forward between analyses

    // fields
    private Bitmap? spectImage;             // stores the generated spectrogram image



    // methods

    /// <summary>
    /// Generates spectrogram data from a track's audio samples.
    /// </summary>
    /// <param name="track">The audio track being used.</param>
    public void Generate(Track track)
    {
        // get the audio data from the track
        float[] samples = track.Samples;
        int channels = track.Channels;
        int sampleRate = track.SampleRate;


        // check that the audio has a valid sample rate and channel count
        if (sampleRate <= 0 || channels <= 0)
        {
            throw new ArgumentException("Track must have a valid sample rate and channel count.");
        }

        // calculate the number of audio frames in the sample array
        int frameCount = samples.Length / channels;

        // check that there are enough audio frames to perform frequency analysis on at least one window
        if (frameCount < WindowSize)
        {
            return;
        }

        // stores a single combined sample for each audio frame
        // this is because an audio file could be in a stereo format, but we need to display mono
        float[] mono = new float[frameCount];

        // goes through each audio frame
        for (int a = 0; a < frameCount; a++)
        {
            // stores total of all channel values for the current frame
            float sum = 0;

            // goes through each channel in the frame
            for (int c = 0; c < channels; c++)
            {
                // add current channel's sample to sum
                sum += samples[a * channels + c];
            }

            // calculate average of the channel values and store it as a mono sample
            mono[a] = sum / channels;
        }

        // creates a digital signal using mono audio samples and sample rate
        DiscreteSignal signal = new(sampleRate, mono);

        // creates an STFT analyzer w/ overlapping windows -- STFT => Short-Time Fourier Transform
        Stft analyzer = new(WindowSize, HopSize);

        // the STFT analyzer calculates the frequency power of each window in the audio signal
        var spectrum = analyzer.Spectrogram(signal);


        // checks to make sure the STFT analyzer produced frequency data, exit if not
        if (spectrum == null || spectrum.Count == 0)
        {
            return;
        }

        // will need dimensions of the spectrogram before we can make the bitmap
        int width = spectrum.Count;         // num time windows in the audio
        int height = spectrum[0].Length;    // num frequency bins per window


        // creates the bitmap that stores the spectrogram image
        Bitmap image = new(width, height);

        // go through each time window of the spectrogram (basically think of this as the column)
        for (int x = 0; x < width; x++)
        {
            // go through each frequency bin in current window (basically the row)
            for (int y = 0; y < height; y++)
            {
                // get frequency power for current window and bin
                float power = spectrum[x][y];


                // converts frequency power to decibels (dB)
                // formula for power measurements (i.e. frequency power to decibels
                // dB = 10 * log10(P), where P is power relative to a reference of 1
                // Math.Max to prevents taking log of zero or negative values, as they can't be calculated
                // 1e-12f = 0.000000000001
                double dB = 10.0 * Math.Log10(Math.Max(power, 1e-12f));


                // will use normalization formula to convert decibel values into
                // a suitable color range for the pixels of the spectrogram image
                // Math.Clamp() ensures the color intensity of the pixel stays within
                // the range of 0.0 to 1.0, inclusive
                double intensity = Math.Clamp((dB + 80) / 80, 0.0, 1.0);


                // convert intensity value into a color for the pixel
                Color pixel = GetColor(intensity);


                // since bitmap coordinates start in top-left corner instead of bottom-left,
                // we must calculate what row the current pixel will go in
                // we do this by reversing the vertical position
                // formula for this --> pixelY = height - 1 - y
                int pixY = height - 1 - y;

                // set color of the pixel at current time window and frequency position
                image.SetPixel(x, pixY, pixel);
            }
        }

        // dispose of the previously generated image if there is one
        // and store the newly generated spectrogram image
        spectImage?.Dispose();
        spectImage = image;

    }



    /// <summary>
    /// A method that determines the color of a pixel in the spectrogram
    /// based on its normalized frequency intensity.
    /// </summary>
    /// <param name="intensity">The normalized frequency intensity.</param>
    /// <returns>The color for the given intensity.</returns>
    private static Color GetColor(double intensity)
    {
        // we will map the normalized frequency intensity to colors as follows:
        //      intensity = 0.00 --> dark blue
        //      intensity = 0.25 --> blue
        //      intensity = 0.50 --> cyan
        //      intensity = 0.75 --> orange
        //      intensity = 1.00 --> yellow

        // we will use linear interpolation to create a smooth transition between each color
        // interpolation formula --- result = start + (end - start) * t
        // where 't' represents the progress between two colors, ranging 0 to 1 (like between 0.00 and 0.25)
        // general formula of t --- t = (intensity - rangeStart) / (rangeEnd - rangeStart)


        // from 0.0 to 0.25, transition from dark blue to blue
        // starting color = RGB(7,17,47), ending color = RGB(24,74,168)
        if (intensity <= 0.25)
        {
            // calculate progress between start and end colors
            // t = (intensity - rangeStart) / (rangeEnd - rangeStart)
            // t = (intensity - 0.00) / (0.25 - 0.00) --> t = intensity / 0.25
            double t = intensity / 0.25;

            // calculates and returns the color between start and end colors
            return InterpolateColor(Color.FromArgb(7,17,47), Color.FromArgb(24,74,168), t);

        }
        // from 0.25 to 0.50, transition from blue to cyan
        // starting color = RGB(24,74,168), ending color = RGB(0,169,199)
        else if (intensity <= 0.50)
        {
            // calculate progress between the colors
            // t = (intensity - rangeStart) / (rangeEnd - rangeStart)
            double t = (intensity - 0.25) / (0.50 - 0.25);

            // calculate and return interpolated color
            return InterpolateColor(Color.FromArgb(24,74,168), Color.FromArgb(0, 169, 199), t);

        }
        // from 0.50 to 0.75, transition from cyan to teal
        // starting color = RGB(0,169,199), ending color = RGB(0,200,150)
        else if (intensity <= 0.75)
        {
            // calculate progress between the colors
            // t = (intensity - rangeStart) / (rangeEnd - rangeStart)
            double t = (intensity - 0.50) / (0.75 - 0.50);

            // calculate and return interpolated color
            return InterpolateColor(Color.FromArgb(0, 169, 199), Color.FromArgb(0, 200, 150), t);

        }
        // from 0.75 to 1.00, transition from teal to green
        // starting color = RGB(0,200,150), ending color = RGB(50,255,100)
        else
        {
            // calculate progress between the colors
            // t = (intensity - rangeStart) / (rangeEnd - rangeStart)
            double t = (intensity - 0.75) / (1.00 - 0.75);

            // calculate and return interpolated color
            return InterpolateColor(Color.FromArgb(0, 200, 150), Color.FromArgb(50, 255, 100), t);

        }
    }



    /// <summary>
    /// Calculates a color between two RGB colors using linear interpolation.
    /// </summary>
    /// <param name="start">The color at the start of the transition.</param>
    /// <param name="end">The color at the end of the transition.</param>
    /// <param name="t">How far through the transition the new color is, ranging from 0 to 1.</param>
    /// <returns>The interpolated color.</returns>
    private static Color InterpolateColor(Color start, Color end, double t)
    {
        // calculates the red component using linear interpolation
        // RGB components must be an int, thus the result is cast to int
        int red = (int)(start.R + (end.R - start.R) * t);

        // calculates the green component
        int green = (int)(start.G + (end.G - start.G) * t);

        // calculates the blue component
        int blue = (int)(start.B + (end.B - start.B) * t);

        // return the final interpolated color
        return Color.FromArgb(red, green,blue);
    }


}
