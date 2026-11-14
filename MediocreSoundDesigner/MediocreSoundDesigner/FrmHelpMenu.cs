using MediocreSoundDesigner.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediocreSoundDesigner
{
    public partial class FrmHelpMenu : Form
    {
        public FrmHelpMenu()
        {
            InitializeComponent();
            if (Program.isDarkMode)
            {
                BackgroundImage = Resources.backgroundTexture;
                BackColor = Program.darkBackground;
                richTextBox1.BackColor = Program.darkForeground;
                richTextBox1.ForeColor = Color.White;
            }
            else
            {
                BackgroundImage = Resources.backgroundTextureLight;
                BackColor = Program.lightForeground;
                richTextBox1.BackColor = Program.lightBackground;
                richTextBox1.ForeColor = Color.Black;
            }
        }
    }
}
