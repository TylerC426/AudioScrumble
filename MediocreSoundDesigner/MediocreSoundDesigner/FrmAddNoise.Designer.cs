namespace MediocreSoundDesigner
{
    partial class FrmAddNoise
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            btnCancel = new Button();
            btnApply = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.Black;
            btnCancel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(89, 213);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 47);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnApply
            // 
            btnApply.AutoSize = true;
            btnApply.BackColor = Color.Black;
            btnApply.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApply.ForeColor = Color.Lime;
            btnApply.Location = new Point(327, 213);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(103, 47);
            btnApply.TabIndex = 8;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(263, 139);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(212, 43);
            numericUpDown1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 139);
            label2.Name = "label2";
            label2.Size = new Size(138, 37);
            label2.TabIndex = 14;
            label2.Text = "Duration:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 49);
            label1.Name = "label1";
            label1.Size = new Size(185, 37);
            label1.TabIndex = 13;
            label1.Text = "Add noise at:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Beginning", "End" });
            comboBox1.Location = new Point(263, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 45);
            comboBox1.TabIndex = 12;
            // 
            // FrmAddNoise
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 303);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
            Name = "FrmAddNoise";
            Text = "Add Noise to Track";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnApply;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
    }
}