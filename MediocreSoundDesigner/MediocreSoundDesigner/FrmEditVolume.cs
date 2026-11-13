using System.Reflection.Emit;

namespace MediocreSoundDesigner;

public partial class FrmEditVolume : FrmEditMaster {
  public FrmEditVolume() {
    InitializeComponent();
        if (Program.isDarkMode)
        {
            btnApply.BackColor = Program.darkForeground;
            btnCancel.BackColor = Program.darkForeground;
            label1.ForeColor = Color.White;
        }
        else
        {
            btnApply.BackColor = Program.lightForeground;
            btnCancel.BackColor = Program.lightForeground;
            label1.ForeColor = Color.Black;
        }
    }

  protected override void Init() {
    nudVolume.Value = (decimal)(track.Volume * 100.0f);
  }

  protected override void Apply() {
    track.SetVolume((float)nudVolume.Value / 100.0f);
  }
}
