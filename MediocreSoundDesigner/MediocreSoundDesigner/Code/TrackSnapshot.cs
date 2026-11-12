
namespace MediocreSoundDesigner;

// Represents a snapshot, or memento, of a track's state.
// Saved values should not be changed after they've been created.
public class TrackSnapshot
{
    // fields
    private readonly float[] samples;                       // track's audio samples when snapshot was created

    // properties
    public float[] Samples => (float[])samples.Clone();     // makes a temp copy of samples array for the purpose of retrieving
    public float Volume { get; }                            // track's volume when snapshot was created
    public int DrawOffset { get; }                          // tracks's horizontal offset when snapshot was created
    public string TrackName { get; }                        // track's name when snapshot was created
    // maybe some more


    // ctor
    public TrackSnapshot(Track track)
    {
        this.samples = track.CloneSamples();
        this.Volume = track.Volume;
        this.DrawOffset = track.DrawOffset;
        this.TrackName = track.TrackName;
    }
}
