using MediocreSoundDesigner.Properties;

namespace MediocreSoundDesigner;

public partial class FrmMain : Form {
  // constants
  private const int TRACK_HEADER_WIDTH = 170;       // base width for the track headers
  private const int DEFAULT_TRACK_HEIGHT = 150;     // base height for each track
  private const int MIN_TRACK_HEIGHT = 60;          // there has to be a minimum to avoid it being made too small or going over itself when resized
  private const int RESIZE_HANDLE_HEIGHT = 6;       // height of the draggable area at bottom of each track

  // fields
  private TrackManager trackManager;

  // ctor
  public FrmMain() {
    InitializeComponent();
    Setup();
  }

  // setup
  /// <summary>
  /// A method that handles the setup of the Track Manager and the track display area
  /// </summary>
  private void Setup() {
    // reduces flickering when controls are redrawn
    DoubleBuffered = true;
    
    // creates the trackManager with the panel containing all tracks
    trackManager = new(panTracks);

    // sets play button's image
    btnPlay.BackgroundImage = Resources.play;
    // sets initial waveform drawing scale using trackbar's value
    trackManager.DrawTimescale = trkDrawTimescale.Value;

    // allows users to scroll when there are more tracks than the visible area can show
    panTracks.AutoScroll = true;

    // position and size the interface's controls
    UpdateSizes();
  }

  // GUI controls
  protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
    if (trackManager.SelectedTrack is not null) {
      if (keyData == Keys.Left) {
        trackManager.SelectedTrack.ShiftSampleOver(-5);
        trackManager.SelectedTrack.PanDrawSamples.Invalidate();
        return true;
      }
      else if (keyData == Keys.Right) {
        trackManager.SelectedTrack.ShiftSampleOver(+5);
        trackManager.SelectedTrack.PanDrawSamples.Invalidate();
        return true;
      }
      else if (keyData == Keys.Delete) {
        // delete whichever track is currently selected
        DeleteTrack(trackManager.SelectedTrack);
        return true;
      }
    }
    return base.ProcessCmdKey(ref msg, keyData);
  }

  private void FrmMain_SizeChanged(object sender, EventArgs e) {
    UpdateSizes();
  }

  private void btnPlay_Click(object sender, EventArgs e) {
    if (trackManager.State is NAudio.Wave.PlaybackState.Stopped or NAudio.Wave.PlaybackState.Paused) {
      trackManager.PlayAll();
      btnPlay.BackgroundImage = Resources.pause;
    }
    else {
      trackManager.PauseAll();
      btnPlay.BackgroundImage = Resources.play;
    }
  }

  private void menuFileOpen_Click(object sender, EventArgs e) {
    ofdLoadFile.DefaultExt = "wav";
    if (ofdLoadFile.ShowDialog() == DialogResult.OK) {
      Track newTrack = new(ofdLoadFile.FileName);
      CreateTrackPanel(newTrack);
      trackManager.AddTrack(newTrack);
      UpdateSizes();
      newTrack.PanDrawSamples.Invalidate();
    }
  }
  private void menuFileSave_Click(object sender, EventArgs e) {
    sfdSaveFile.DefaultExt = "wav";
    if (sfdSaveFile.ShowDialog() == DialogResult.OK) {
      trackManager.SaveToFile(sfdSaveFile.FileName);
    }
  }

  private void menuEditFlip_Click(object sender, EventArgs e) {
    trackManager.SelectedTrack?.Flip();
  }
  private void menuEditReverse_Click(object sender, EventArgs e) {
    trackManager.SelectedTrack?.Reverse();
  }
  private void menuEditVolume_Click(object sender, EventArgs e) {
    if (trackManager.SelectedTrack is not null) {
      FrmEditVolume frm = new();
      frm.SetSound(trackManager.SelectedTrack);
      frm.ShowDialog();
    }
  }
  private void menuEditEliminateSilence_Click(object sender, EventArgs e) {
    if (trackManager.SelectedTrack is not null) {
      FrmEditEliminateSilence frm = new();
      frm.SetSound(trackManager.SelectedTrack);
      frm.ShowDialog();
    }
  }

  private void menuGenRecord_Click(object sender, EventArgs e) {
    Track newTrack = new(new float[0]);
    CreateTrackPanel(newTrack);
    trackManager.AddTrack(newTrack);
    UpdateSizes();
    newTrack.PanDrawSamples.Invalidate();

    FrmGenRecord frm = new();
    frm.SetSound(trackManager.SelectedTrack);
    if (frm.ShowDialog() == DialogResult.Cancel) {
      trackManager.RemTrack(newTrack);
    }
  }
  private void menuGenNoise_Click(object sender, EventArgs e) {
    const int NUM_SAMPLES = 100_000;
    float[] samples = new float[NUM_SAMPLES];
    Random rand = new();
    for (int i = 0; i < NUM_SAMPLES; i++) {
      samples[i] = rand.NextSingle() * 2.0f - 1.0f;
    }
    Track newTrack = new(samples);
    CreateTrackPanel(newTrack);
    trackManager.AddTrack(newTrack);
    UpdateSizes();
    newTrack.PanDrawSamples.Invalidate();
  }
  private void menuGenGradientNoise_Click(object sender, EventArgs e) {
    const int NUM_SAMPLES = 250_000;
    float[] samples = new float[NUM_SAMPLES];
    Random rand = new();
    float cur = 0;
    float inc = 0.005f;
    int dir = +1;
    for (int i = 0; i < NUM_SAMPLES; i++) {
      cur += (inc * dir);
      if (rand.NextSingle() < 0.5f) {
        dir *= -1;
      }
      if (cur > 0.9f) {
        dir = -1;
      }
      if (cur < -0.9f) {
        dir = +1;
      }
      samples[i] = cur;
    }
    Track newTrack = new(samples);
    CreateTrackPanel(newTrack);
    trackManager.AddTrack(newTrack);
    UpdateSizes();
    newTrack.PanDrawSamples.Invalidate();
  }

  private void tmrUpdatePlaybackState_Tick(object sender, EventArgs e) {
    if (trackManager.Tracks.Count > 0) {
      btnPlay.BackgroundImage = trackManager.State == NAudio.Wave.PlaybackState.Playing ? Resources.pause : Resources.play;
      btnPlay.Visible = true;
      lblPlayhead.Left = TRACK_HEADER_WIDTH + trackManager.GetPlayheadPos();
      lblPlayhead.Visible = true;
    }
    else {
      btnPlay.BackgroundImage = null;
      btnPlay.Visible = false;
      lblPlayhead.Visible = false;
    }
  }

  private void trkDrawTimescale_Scroll(object sender, EventArgs e) {
    trackManager.DrawTimescale = trkDrawTimescale.Value;
    trackManager.RedrawAll();
  }

  // Helper methods
  /// <summary>
  /// A method to create a panel for a new track
  /// </summary>
  /// <param name="track">The new track being added.</param>
  /// <returns>The panel of the newly added track.</returns>
  private Panel CreateTrackPanel(Track track) {
    // main panel, essentially the 'parent' panel for the entire track
    Panel pan = new() {
      BackColor = Color.DimGray,
      Width = panTracks.ClientSize.Width,
      Height = DEFAULT_TRACK_HEIGHT,
      Left = 0,
      Top = 0,
    };


    // header panel that will be on left side of track and contain the name label and options button
    Panel trackHeader = new() {
      BackColor = Color.DarkSlateGray,
      Width = TRACK_HEADER_WIDTH,
      Dock = DockStyle.Left
    };


   // label to display the current name of the track
    Label lblTrackName = new() {
      Text = track.TrackName, ForeColor = Color.White,
      BackColor = Color.DarkSlateGray, Dock = DockStyle.Fill,
      TextAlign = ContentAlignment.MiddleCenter,
      Padding = new Padding(8, 0, 0, 0), AutoEllipsis = true
    };

    // will use a context strip to hold track options such as renaming and deleting
    ContextMenuStrip trackMenu = new();

    // creates option to "Rename" a track
    ToolStripMenuItem rename = new("Rename");
    // creates option to "Delete" a track
    ToolStripMenuItem delete = new("Delete");

    // adds the Rename and Delete options to the track menu
    trackMenu.Items.Add(rename);
    trackMenu.Items.Add(delete);


    // now the button for the context menu needs to be created and added to the name label
    // should be displayed to the right of the track name
    Button trackOptions = new() {
      Text = "\u22EE", Width = 30, Dock = DockStyle.Right,
      FlatStyle = FlatStyle.Flat, BackColor = Color.DarkSlateGray,
      ForeColor = Color.White, Cursor = Cursors.Hand
    };
    // removes the default button border
    trackOptions.FlatAppearance.BorderSize = 0;


    // click event for the trackOptions button
    // opens the menu when clicked
    trackOptions.Click += (sender, e) => {
      trackMenu.Show(trackOptions, 0, trackOptions.Height);
    };

    // handles events for the context menu options
    rename.Click += (sender, e) => {
      // must prevent multiple text boxes from being created
      if (lblTrackName.Controls.OfType<TextBox>().Any()) {
        return;
      }
    
      // use a temp text box to type in the new name
      TextBox txtRename = new() {
        Text = track.TrackName, Width = lblTrackName.ClientSize.Width - 12,
        Left = 6, BorderStyle = BorderStyle.FixedSingle
       };

      // set the textbox to be positioned over the current name
      txtRename.Top = (lblTrackName.ClientSize.Height - txtRename.Height) / 2;

      // displays the textbox inside the name label
      lblTrackName.Controls.Add(txtRename);
      txtRename.BringToFront();

      // auto focuses the textbox and selects the current name
      txtRename.Focus();
      txtRename.SelectAll();

      // handles "Enter" and "Esc" while typing the new name
      txtRename.KeyDown += (s, args) => {
        if (args.KeyCode == Keys.Enter) {
          // removes any extra spaces from beginning and end of name
          string newName = txtRename.Text.Trim();

          // makes sure the name is not empty before saving it
          if (!string.IsNullOrWhiteSpace(newName)) {
            track.TrackName = newName;
            lblTrackName.Text = newName;
          }

          // removes the temp textbox
          txtRename.Dispose();

          // prevents the Enter key from producing a system sound
          args.SuppressKeyPress = true;

        } else if (args.KeyCode == Keys.Escape) {
          // cancels renaming without changing the track name
          txtRename.Dispose();
          args.SuppressKeyPress= true;
        }
      };
    };

    // handles the "Delete" option
    // deletes this specific track when selected
    delete.Click += (sender, e) => {
      DeleteTrack(track);
    };


    // adds the name label and options button to the header
    // the order here DOES matter
    trackHeader.Controls.Add(lblTrackName);
    trackHeader.Controls.Add(trackOptions);


    // will use this for displaying the wave form
    Panel waveForm = new() {
      BackColor= Color.Gray, Dock = DockStyle.Fill
    };

    // this panel will be used to allow the user to change the height of the track
    // done by clicking and dragging this area up or down
    Panel resizeHandle = new() {
      BackColor = Color.DarkGray, Height = RESIZE_HANDLE_HEIGHT,
      Dock = DockStyle.Bottom, Cursor = Cursors.SizeNS
    };

    // tracks whether user is currently dragging resize handle
    bool isDragging = false;

    // position of the mouse when the user started dragging
    int startY = 0;

    // track height before user began dragging
    int startHeight = 0;

    // called when user pressses left mouse button on resize handle
    resizeHandle.MouseDown += (sender, e) => {
      // only begin resizing when left mouse button is pressed
      if (e.Button == MouseButtons.Left) {
        isDragging = true;

        // save original vertical position of the mouse
        startY = Cursor.Position.Y;

        // save track's height before resizing
        startHeight = pan.Height;

        // keep receiving mouse events even if cursor moves outside handle
        resizeHandle.Capture = true;
      }
    };

    // called when mouse moves over resize handle
    resizeHandle.MouseMove += (sender, e) => {
      // ignore movement unless draggin
      if (!isDragging) {
        return;
      }

      // calculates how far mouse has moved since it started dragging
      // pos = down, neg = up
      int difference = Cursor.Position.Y - startY;

      // changes only this tracks height
      // uses Math.Max to prevent going below the minimum
      pan.Height = Math.Max(MIN_TRACK_HEIGHT,startHeight + difference);

      // move other tracks as needed
      UpdateSizes();
    };

    // called when user release button
    resizeHandle.MouseUp += (sender, e) => {
      // stops resizing when left button is released
      if (e.Button == MouseButtons.Left) {
        isDragging = false;

        // stops the mouse capture
        resizeHandle.Capture = false;
      }
    };


    // add the header, waveform, and resizeHandle panels to the main track panel
    // the order DOES matter
    pan.Controls.Add(waveForm);
    pan.Controls.Add(trackHeader);
    pan.Controls.Add(resizeHandle);


    // select this track when its waveform is clicked
    waveForm.Click += (sender, e) => {
      trackManager.SelectTrack(track);
    };

    // double clicking waveform enables/disables the track
    waveForm.DoubleClick += (sender, e) => {
      track.ToggleDisabled();
      track.PanDrawSamples.Invalidate();
    };

    // draws the waveform whenever its panel needs to be redrawn
    waveForm.Paint += (sender, e) => {
      track.DrawSamples(e.Graphics, trackManager.DrawTimescale);
    };

    // adds full track panel to the track container
    panTracks.Controls.Add(pan);

    // links waveform panel to Track object
    track.LinkPanels(waveForm, panTracks);

    // auto selects the new track
    trackManager.SelectTrack(track);

    return pan;
  }

  /// <summary>
  /// A method that updates the sizes for each displayed track.
  /// </summary>
  private void UpdateSizes() {
    // horizontal spacing between the track container and window edges
    const int PADDING = 15;

    // keeps track container positioned 15 pixels from left edge
    panTracks.Left = PADDING;
    // sets track container to fill the window width, while still leaving padding space on each side
    panTracks.Width = ClientSize.Width - (PADDING * 2);

    // remembers current vertical scroll position
    // zero at top and negative when scrolled down
    int scrollY = panTracks.AutoScrollPosition.Y;

    // track
    // tracks the vertical position where next track should begin
    int top = scrollY;

    // temp suspend layout while repositioning tracks
    panTracks.SuspendLayout();

    // goes through each track in the track manager, if there are any
    foreach (Track track in trackManager?.Tracks ?? []) {
      // need to access the parent panel so tracks won't overlap
      Panel pan = (Panel)track.PanDrawSamples.Parent;

      // keep track aligned w/ left side of container
      pan.Left = 0;
      // make track span available width
      pan.Width = panTracks.ClientSize.Width;

      // no longer need to change height here
      //pan.Height = (panTracks.ClientSize.Height / trackManager.Tracks.Count) - 1;

      // position this track directly beneath previous track
      pan.Top = top;

      // redraw waveform to fit current space
      track.PanDrawSamples.Invalidate();

      // next track begins at bottom of this one
      top += pan.Height;
    }

    // resume normal layout
    panTracks.ResumeLayout();

    // keep waveform timescale control aligned with track container
    trkDrawTimescale.Width = panTracks.Width;
    trkDrawTimescale.Left = PADDING;

    // position playhead at beginning of waveform area
    lblPlayhead.Left = TRACK_HEADER_WIDTH;

    // make playhead span height of track container
    lblPlayhead.Height = panTracks.Height;

    // ensures that the playhead is drawn above the waveforms
    lblPlayhead.BringToFront();
  }

  /// <summary>
  /// A method that deletes the given track.
  /// </summary>
  /// <param name="track"> The track to be deleted.</param>
  private void DeleteTrack(Track track) {
    // make sure the track exists first
    if (track == null) return;

    // ask user to confirm the deletion of the track
    DialogResult result = MessageBox.Show($"Are you sure you want to delete '{track.TrackName}'?\nThis CANNOT be undone.", "Delete Track", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

    // if user selects No, cancel deletion
    if (result != DialogResult.Yes) {
      return;
    }

    // get parent panel of the track
    Panel pan = (Panel)track.PanDrawSamples.Parent;

    // remove the track from the manage
    trackManager.RemTrack(track);

    // remove entire track panel from interface
    panTracks.Controls.Remove(pan);

    // dispose of the parent panel and its attached panels
    pan.Dispose();

    // release audio resources of the track
    track.Dispose();

    // reposition remaining tracks
    UpdateSizes();
  }
}
