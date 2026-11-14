
namespace MediocreSoundDesigner;

public partial class FrmAddNoise : FrmEditMaster
{
    public FrmAddNoise()
    {
        InitializeComponent();
        if (Program.isDarkMode)
        {
            btnApply.BackColor = Program.darkForeground;
            btnCancel.BackColor = Program.darkForeground;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
        }
        else
        {
            btnApply.BackColor = Program.lightForeground;
            btnCancel.BackColor = Program.lightForeground;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
        }
    }

    protected override void Init()
    {
        comboBox1.SelectedIndex = 0;
    }

    protected override void Apply()
    {
        SampleRegion region = comboBox1.SelectedIndex switch
        {
            0 => SampleRegion.BEGINNING_ONLY,
            1 => SampleRegion.END_ONLY,
        };
        track.AddNoise(region, (int)numericUpDown1.Value);
    }

}
