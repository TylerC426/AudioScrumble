

using System.Reflection.Emit;

namespace MediocreSoundDesigner;

public partial class FrmAddSilenceNew : FrmEditMaster
{
    public FrmAddSilenceNew()
    {
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

}
