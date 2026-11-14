namespace MediocreSoundDesigner;

public partial class FrmEditEliminateSilence : FrmEditMaster {
  public FrmEditEliminateSilence() {
    InitializeComponent();
        if (Program.isDarkMode)
        {
            btnApply.BackColor = Program.darkForeground;
            btnCancel.BackColor = Program.darkForeground;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
        }
        else
        {
            btnApply.BackColor = Program.lightForeground;
            btnCancel.BackColor = Program.lightForeground;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
        }
    }

  protected override void Init() {
    cmbWhere.SelectedIndex = 0;
  }

  protected override void Apply() {
    SampleRegion region = cmbWhere.SelectedIndex switch {
      0 => SampleRegion.BEGINNING_ONLY,
      1 => SampleRegion.END_ONLY,
      2 => SampleRegion.BEGINNING_AND_END,
      3 => SampleRegion.ANYWHERE
    };
    track.EliminateSilence(region, (float)nudMinDuration.Value, (float)nudThreshold.Value);
  }
}
