using MediocreSoundDesigner.Properties;

namespace MediocreSoundDesigner;

public partial class FrmEditMaster : Form {
  // fields
  protected Track track;

  // ctor
  public FrmEditMaster() {
    InitializeComponent();
    if (Program.isDarkMode)
        {
            BackColor = Color.FromArgb(18, 16, 24);
            panel1.BackColor = Color.FromArgb(41, 55, 71);
            BackgroundImage = Resources.backgroundTexture;
        }
        else
        {
            BackColor = Color.FromArgb(206, 234, 215);
            panel1.BackColor = Color.FromArgb(66, 91, 88);
            BackgroundImage = Resources.backgroundTextureLight;
        }
  }

  // sound
  public virtual void SetSound(Track sound) {
    this.track = sound;
    Init();
  }

  // gui
  public void btnCancel_Click(object sender, EventArgs e) {
    Cancel();
    DialogResult = DialogResult.Cancel;
    Close();
  }

  public void btnApply_Click(object sender, EventArgs e) {
    Apply();
    track.PanDrawSamples?.Invalidate();
    DialogResult = DialogResult.OK;
    Close();
  }

  // override in subclass if needed
  protected virtual void Init() { }
  protected virtual void Apply() { }
  protected virtual void Cancel() { }
}
