
namespace MediocreSoundDesigner;

public partial class FrmAddNoise : FrmEditMaster
{
    public FrmAddNoise()
    {
        InitializeComponent();
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
