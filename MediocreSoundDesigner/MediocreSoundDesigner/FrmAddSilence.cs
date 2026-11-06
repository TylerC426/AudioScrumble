
namespace MediocreSoundDesigner;

public partial class FrmAddSilence : FrmEditMaster
{
    public FrmAddSilence()
    {
        InitializeComponent();
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected override void Apply()
    {
        SampleRegion region = comboBox1.SelectedIndex switch
        {
            0 => SampleRegion.BEGINNING_ONLY,
            1 => SampleRegion.END_ONLY,
        };
        track.AddSilence(region, (int)numericUpDown1.Value);
    }
}

