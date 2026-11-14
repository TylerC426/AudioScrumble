namespace MediocreSoundDesigner
{
    partial class FrmSpeedUp
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            btnCancel = new Button();
            btnApply = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Speed Up", "Slow Down" });
            comboBox1.Location = new Point(348, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(193, 45);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 43);
            label1.Name = "label1";
            label1.Size = new Size(188, 37);
            label1.TabIndex = 1;
            label1.Text = "Track Should:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 146);
            label2.Name = "label2";
            label2.Size = new Size(250, 37);
            label2.TabIndex = 2;
            label2.Text = "Times How Much?";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(348, 146);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(193, 43);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.BackColor = Color.Black;
            btnCancel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(151, 224);
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
            btnApply.Location = new Point(348, 224);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(103, 47);
            btnApply.TabIndex = 8;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // FrmSpeedUp
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 314);
            Controls.Add(btnApply);
            Controls.Add(btnCancel);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "FrmSpeedUp";
            Text = "Alter Speed";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button btnCancel;
        private Button btnApply;
    }
}