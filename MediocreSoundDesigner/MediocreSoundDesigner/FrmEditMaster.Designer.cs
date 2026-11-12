namespace MediocreSoundDesigner {
  partial class FrmEditMaster {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(41, 55, 71);
            panel1.Location = new Point(41, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 300);
            panel1.TabIndex = 0;
            // 
            // FrmEditMaster
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 16, 24);
            BackgroundImage = Properties.Resources.backgroundTexture;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(575, 383);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(7);
            Name = "FrmEditMaster";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmEditMaster";
            ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
    }
}