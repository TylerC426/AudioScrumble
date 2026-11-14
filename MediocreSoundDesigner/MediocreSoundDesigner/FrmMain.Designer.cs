namespace MediocreSoundDesigner
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panTracks = new Panel();
            lblPlayhead = new Label();
            lblDebug = new Label();
            ofdLoadFile = new OpenFileDialog();
            menu = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuFileOpen = new ToolStripMenuItem();
            menuFileSave = new ToolStripMenuItem();
            menuEdit = new ToolStripMenuItem();
            menuEditUndo = new ToolStripMenuItem();
            menuEditRedo = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuEditFlip = new ToolStripMenuItem();
            menuEditReverse = new ToolStripMenuItem();
            menuEditVolume = new ToolStripMenuItem();
            menuEditEliminateSilence = new ToolStripMenuItem();
            menuGen = new ToolStripMenuItem();
            menuGenRecord = new ToolStripMenuItem();
            addNoiseToTrackToolStripMenuItem = new ToolStripMenuItem();
            menuGenNoise = new ToolStripMenuItem();
            addSilenceToolStripMenuItem = new ToolStripMenuItem();
            addSilenceAsNewToolStripMenuItem = new ToolStripMenuItem();
            menuGenGradientNoise = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            btnPlay = new Button();
            tmrUpdate = new System.Windows.Forms.Timer(components);
            sfdSaveFile = new SaveFileDialog();
            trkDrawTimescale = new TrackBar();
            colorDialog = new ColorDialog();
            LoopEnableButton = new Button();
            btnPlayFromBeginning = new Button();
            panTracks.SuspendLayout();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkDrawTimescale).BeginInit();
            SuspendLayout();
            // 
            // panTracks
            // 
            panTracks.AutoScroll = true;
            panTracks.BackColor = Color.DimGray;
            panTracks.BorderStyle = BorderStyle.Fixed3D;
            panTracks.Controls.Add(lblPlayhead);
            panTracks.Location = new Point(14, 170);
            panTracks.Margin = new Padding(4, 5, 4, 5);
            panTracks.Name = "panTracks";
            panTracks.Size = new Size(2255, 899);
            panTracks.TabIndex = 0;
            // 
            // lblPlayhead
            // 
            lblPlayhead.BackColor = Color.White;
            lblPlayhead.Location = new Point(56, -3);
            lblPlayhead.Margin = new Padding(4, 0, 4, 0);
            lblPlayhead.Name = "lblPlayhead";
            lblPlayhead.Size = new Size(7, 642);
            lblPlayhead.TabIndex = 9;
            // 
            // lblDebug
            // 
            lblDebug.Dock = DockStyle.Bottom;
            lblDebug.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDebug.ForeColor = Color.FromArgb(255, 255, 192);
            lblDebug.Location = new Point(0, 1243);
            lblDebug.Margin = new Padding(4, 0, 4, 0);
            lblDebug.Name = "lblDebug";
            lblDebug.Size = new Size(2291, 62);
            lblDebug.TabIndex = 1;
            // 
            // ofdLoadFile
            // 
            ofdLoadFile.FileName = "openFileDialog1";
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(24, 24);
            menu.Items.AddRange(new ToolStripItem[] { menuFile, menuEdit, menuGen, helpToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new Padding(9, 3, 0, 3);
            menu.Size = new Size(2291, 35);
            menu.TabIndex = 5;
            menu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuFileOpen, menuFileSave });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(54, 29);
            menuFile.Text = "&File";
            // 
            // menuFileOpen
            // 
            menuFileOpen.Name = "menuFileOpen";
            menuFileOpen.Size = new Size(170, 34);
            menuFileOpen.Text = "Open...";
            menuFileOpen.Click += menuFileOpen_Click;
            // 
            // menuFileSave
            // 
            menuFileSave.Name = "menuFileSave";
            menuFileSave.Size = new Size(170, 34);
            menuFileSave.Text = "Save...";
            menuFileSave.Click += menuFileSave_Click;
            // 
            // menuEdit
            // 
            menuEdit.DropDownItems.AddRange(new ToolStripItem[] { menuEditUndo, menuEditRedo, toolStripSeparator1, menuEditFlip, menuEditReverse, menuEditVolume, menuEditEliminateSilence });
            menuEdit.Name = "menuEdit";
            menuEdit.Size = new Size(58, 29);
            menuEdit.Text = "E&dit";
            // 
            // menuEditUndo
            // 
            menuEditUndo.Name = "menuEditUndo";
            menuEditUndo.ShortcutKeys = Keys.Control | Keys.Z;
            menuEditUndo.Size = new Size(256, 34);
            menuEditUndo.Text = "Undo";
            menuEditUndo.Click += menuEditUndo_Click;
            // 
            // menuEditRedo
            // 
            menuEditRedo.Name = "menuEditRedo";
            menuEditRedo.ShortcutKeys = Keys.Control | Keys.Y;
            menuEditRedo.Size = new Size(256, 34);
            menuEditRedo.Text = "Redo";
            menuEditRedo.Click += menuEditRedo_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(253, 6);
            // 
            // menuEditFlip
            // 
            menuEditFlip.Name = "menuEditFlip";
            menuEditFlip.Size = new Size(256, 34);
            menuEditFlip.Text = "Flip";
            menuEditFlip.Click += menuEditFlip_Click;
            // 
            // menuEditReverse
            // 
            menuEditReverse.Name = "menuEditReverse";
            menuEditReverse.Size = new Size(256, 34);
            menuEditReverse.Text = "Reverse";
            menuEditReverse.Click += menuEditReverse_Click;
            // 
            // menuEditVolume
            // 
            menuEditVolume.Name = "menuEditVolume";
            menuEditVolume.Size = new Size(256, 34);
            menuEditVolume.Text = "Alter Volume...";
            menuEditVolume.Click += menuEditVolume_Click;
            // 
            // menuEditEliminateSilence
            // 
            menuEditEliminateSilence.Name = "menuEditEliminateSilence";
            menuEditEliminateSilence.Size = new Size(256, 34);
            menuEditEliminateSilence.Text = "Eliminate Silence...";
            menuEditEliminateSilence.Click += menuEditEliminateSilence_Click;
            // 
            // menuGen
            // 
            menuGen.DropDownItems.AddRange(new ToolStripItem[] { menuGenRecord, addNoiseToTrackToolStripMenuItem, menuGenNoise, addSilenceToolStripMenuItem, addSilenceAsNewToolStripMenuItem, menuGenGradientNoise });
            menuGen.Name = "menuGen";
            menuGen.Size = new Size(98, 29);
            menuGen.Text = "&Generate";
            // 
            // menuGenRecord
            // 
            menuGenRecord.Name = "menuGenRecord";
            menuGenRecord.Size = new Size(285, 34);
            menuGenRecord.Text = "Record...";
            menuGenRecord.Click += menuGenRecord_Click;
            // 
            // addNoiseToTrackToolStripMenuItem
            // 
            addNoiseToTrackToolStripMenuItem.Name = "addNoiseToTrackToolStripMenuItem";
            addNoiseToTrackToolStripMenuItem.Size = new Size(285, 34);
            addNoiseToTrackToolStripMenuItem.Text = "Add Noise to Track...";
            addNoiseToTrackToolStripMenuItem.Click += addNoiseToTrackToolStripMenuItem_Click;
            // 
            // menuGenNoise
            // 
            menuGenNoise.Name = "menuGenNoise";
            menuGenNoise.Size = new Size(285, 34);
            menuGenNoise.Text = "Add Noise as New";
            menuGenNoise.Click += menuGenNoise_Click;
            // 
            // addSilenceToolStripMenuItem
            // 
            addSilenceToolStripMenuItem.Name = "addSilenceToolStripMenuItem";
            addSilenceToolStripMenuItem.Size = new Size(285, 34);
            addSilenceToolStripMenuItem.Text = "Add Silence to Track...";
            addSilenceToolStripMenuItem.Click += addSilenceToolStripMenuItem_Click;
            // 
            // addSilenceAsNewToolStripMenuItem
            // 
            addSilenceAsNewToolStripMenuItem.Name = "addSilenceAsNewToolStripMenuItem";
            addSilenceAsNewToolStripMenuItem.Size = new Size(285, 34);
            addSilenceAsNewToolStripMenuItem.Text = "Add Silence as New";
            addSilenceAsNewToolStripMenuItem.Click += addSilenceAsNewToolStripMenuItem_Click;
            // 
            // menuGenGradientNoise
            // 
            menuGenGradientNoise.Name = "menuGenGradientNoise";
            menuGenGradientNoise.Size = new Size(285, 34);
            menuGenGradientNoise.Text = "Gradient Noise";
            menuGenGradientNoise.Click += menuGenGradientNoise_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(77, 29);
            helpToolStripMenuItem.Text = "&Help...";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // btnPlay
            // 
            btnPlay.AutoSize = true;
            btnPlay.BackColor = Color.Transparent;
            btnPlay.BackgroundImage = Properties.Resources.play;
            btnPlay.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPlay.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(1024, 1102);
            btnPlay.Margin = new Padding(4, 5, 4, 5);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(143, 167);
            btnPlay.TabIndex = 6;
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // tmrUpdate
            // 
            tmrUpdate.Enabled = true;
            tmrUpdate.Interval = 20;
            tmrUpdate.Tick += tmrUpdatePlaybackState_Tick;
            // 
            // trkDrawTimescale
            // 
            trkDrawTimescale.LargeChange = 50;
            trkDrawTimescale.Location = new Point(17, 92);
            trkDrawTimescale.Margin = new Padding(4, 5, 4, 5);
            trkDrawTimescale.Maximum = 1000;
            trkDrawTimescale.Minimum = 1;
            trkDrawTimescale.Name = "trkDrawTimescale";
            trkDrawTimescale.Size = new Size(2257, 69);
            trkDrawTimescale.SmallChange = 10;
            trkDrawTimescale.TabIndex = 7;
            trkDrawTimescale.TickFrequency = 10;
            trkDrawTimescale.Value = 500;
            trkDrawTimescale.Scroll += trkDrawTimescale_Scroll;
            // 
            // LoopEnableButton
            // 
            LoopEnableButton.BackColor = Color.Red;
            LoopEnableButton.Location = new Point(1233, 1102);
            LoopEnableButton.Margin = new Padding(4, 5, 4, 5);
            LoopEnableButton.Name = "LoopEnableButton";
            LoopEnableButton.Size = new Size(156, 150);
            LoopEnableButton.TabIndex = 8;
            LoopEnableButton.Text = "loop";
            LoopEnableButton.UseVisualStyleBackColor = false;
            LoopEnableButton.Click += LoopEnableButton_Click;
            // 
            // btnPlayFromBeginning
            // 
            btnPlayFromBeginning.Location = new Point(841, 1102);
            btnPlayFromBeginning.Name = "btnPlayFromBeginning";
            btnPlayFromBeginning.Size = new Size(143, 167);
            btnPlayFromBeginning.TabIndex = 9;
            btnPlayFromBeginning.Text = "Restart";
            btnPlayFromBeginning.UseVisualStyleBackColor = true;
            btnPlayFromBeginning.Click += btnPlayFromBeginning_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(2291, 1305);
            Controls.Add(btnPlayFromBeginning);
            Controls.Add(LoopEnableButton);
            Controls.Add(trkDrawTimescale);
            Controls.Add(btnPlay);
            Controls.Add(lblDebug);
            Controls.Add(panTracks);
            Controls.Add(menu);
            KeyPreview = true;
            MainMenuStrip = menu;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMain";
            Text = "Mediocre Sound Designer";
            FormClosing += FrmMain_FormClosing;
            SizeChanged += FrmMain_SizeChanged;
            panTracks.ResumeLayout(false);
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkDrawTimescale).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panTracks;
        private Label lblDebug;
        private OpenFileDialog ofdLoadFile;
        private MenuStrip menu;
        private ToolStripMenuItem menuEdit;
        private Button btnPlay;
        private ToolStripMenuItem menuEditVolume;
        private ToolStripMenuItem menuEditReverse;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuFileOpen;
        private ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.Timer tmrUpdate;
        private ToolStripMenuItem menuGen;
        private ToolStripMenuItem menuGenNoise;
        private ToolStripMenuItem menuGenGradientNoise;
        private ToolStripMenuItem menuEditFlip;
        private SaveFileDialog sfdSaveFile;
        private TrackBar trkDrawTimescale;
        private ColorDialog colorDialog;
        private ToolStripMenuItem menuEditEliminateSilence;
        private Label lblPlayhead;
        private ToolStripMenuItem menuGenRecord;
        private ToolStripMenuItem helpToolStripMenuItem;
        private Button LoopEnableButton;
        private ToolStripMenuItem addSilenceToolStripMenuItem;
        private ToolStripMenuItem addSilenceAsNewToolStripMenuItem;
        private ToolStripMenuItem addNoiseToTrackToolStripMenuItem;
        private ToolStripMenuItem menuEditUndo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuEditRedo;
        private Button btnPlayFromBeginning;
    }
}
