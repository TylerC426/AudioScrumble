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
            colorThemeToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            lightToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            btnPlay = new Button();
            tmrUpdate = new System.Windows.Forms.Timer(components);
            sfdSaveFile = new SaveFileDialog();
            trkDrawTimescale = new TrackBar();
            colorDialog = new ColorDialog();
            LoopEnableButton = new Button();
            pnlTrackBackground = new Panel();
            pnlButtonBackground = new Panel();
            panTracks.SuspendLayout();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkDrawTimescale).BeginInit();
            pnlTrackBackground.SuspendLayout();
            pnlButtonBackground.SuspendLayout();
            SuspendLayout();
            // 
            // panTracks
            // 
            panTracks.AutoScroll = true;
            panTracks.BackColor = Color.FromArgb(18, 16, 24);
            panTracks.BorderStyle = BorderStyle.Fixed3D;
            panTracks.Controls.Add(lblPlayhead);
            panTracks.Location = new Point(18, 70);
            panTracks.Name = "panTracks";
            panTracks.Size = new Size(1497, 508);
            panTracks.TabIndex = 0;
            // 
            // lblPlayhead
            // 
            lblPlayhead.BackColor = Color.White;
            lblPlayhead.Location = new Point(39, -2);
            lblPlayhead.Name = "lblPlayhead";
            lblPlayhead.Size = new Size(5, 385);
            lblPlayhead.TabIndex = 9;
            // 
            // lblDebug
            // 
            lblDebug.BackColor = Color.Transparent;
            lblDebug.Dock = DockStyle.Bottom;
            lblDebug.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDebug.ForeColor = Color.FromArgb(255, 255, 192);
            lblDebug.Location = new Point(0, 752);
            lblDebug.Name = "lblDebug";
            lblDebug.Size = new Size(1604, 37);
            lblDebug.TabIndex = 1;
            // 
            // ofdLoadFile
            // 
            ofdLoadFile.FileName = "openFileDialog1";
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { menuFile, menuEdit, menuGen, colorThemeToolStripMenuItem, helpToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1604, 24);
            menu.TabIndex = 5;
            menu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuFileOpen, menuFileSave });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(37, 20);
            menuFile.Text = "&File";
            // 
            // menuFileOpen
            // 
            menuFileOpen.Name = "menuFileOpen";
            menuFileOpen.Size = new Size(112, 22);
            menuFileOpen.Text = "Open...";
            menuFileOpen.Click += menuFileOpen_Click;
            // 
            // menuFileSave
            // 
            menuFileSave.Name = "menuFileSave";
            menuFileSave.Size = new Size(112, 22);
            menuFileSave.Text = "Save...";
            menuFileSave.Click += menuFileSave_Click;
            // 
            // menuEdit
            // 
            menuEdit.DropDownItems.AddRange(new ToolStripItem[] { menuEditFlip, menuEditReverse, menuEditVolume, menuEditEliminateSilence });
            menuEdit.Name = "menuEdit";
            menuEdit.Size = new Size(39, 20);
            menuEdit.Text = "E&dit";
            // 
            // menuEditFlip
            // 
            menuEditFlip.Name = "menuEditFlip";
            menuEditFlip.Size = new Size(172, 22);
            menuEditFlip.Text = "Flip";
            menuEditFlip.Click += menuEditFlip_Click;
            // 
            // menuEditReverse
            // 
            menuEditReverse.Name = "menuEditReverse";
            menuEditReverse.Size = new Size(172, 22);
            menuEditReverse.Text = "Reverse";
            menuEditReverse.Click += menuEditReverse_Click;
            // 
            // menuEditVolume
            // 
            menuEditVolume.Name = "menuEditVolume";
            menuEditVolume.Size = new Size(172, 22);
            menuEditVolume.Text = "Alter Volume...";
            menuEditVolume.Click += menuEditVolume_Click;
            // 
            // menuEditEliminateSilence
            // 
            menuEditEliminateSilence.Name = "menuEditEliminateSilence";
            menuEditEliminateSilence.Size = new Size(172, 22);
            menuEditEliminateSilence.Text = "Eliminate Silence...";
            menuEditEliminateSilence.Click += menuEditEliminateSilence_Click;
            // 
            // menuGen
            // 
            menuGen.DropDownItems.AddRange(new ToolStripItem[] { menuGenRecord, addNoiseToTrackToolStripMenuItem, menuGenNoise, addSilenceToolStripMenuItem, addSilenceAsNewToolStripMenuItem, menuGenGradientNoise });
            menuGen.Name = "menuGen";
            menuGen.Size = new Size(66, 20);
            menuGen.Text = "&Generate";
            // 
            // menuGenRecord
            // 
            menuGenRecord.Name = "menuGenRecord";
            menuGenRecord.Size = new Size(190, 22);
            menuGenRecord.Text = "Record...";
            menuGenRecord.Click += menuGenRecord_Click;
            // 
            // addNoiseToTrackToolStripMenuItem
            // 
            addNoiseToTrackToolStripMenuItem.Name = "addNoiseToTrackToolStripMenuItem";
            addNoiseToTrackToolStripMenuItem.Size = new Size(190, 22);
            addNoiseToTrackToolStripMenuItem.Text = "Add Noise to Track...";
            addNoiseToTrackToolStripMenuItem.Click += addNoiseToTrackToolStripMenuItem_Click;
            // 
            // menuGenNoise
            // 
            menuGenNoise.Name = "menuGenNoise";
            menuGenNoise.Size = new Size(190, 22);
            menuGenNoise.Text = "Add Noise as New";
            menuGenNoise.Click += menuGenNoise_Click;
            // 
            // addSilenceToolStripMenuItem
            // 
            addSilenceToolStripMenuItem.Name = "addSilenceToolStripMenuItem";
            addSilenceToolStripMenuItem.Size = new Size(190, 22);
            addSilenceToolStripMenuItem.Text = "Add Silence to Track...";
            addSilenceToolStripMenuItem.Click += addSilenceToolStripMenuItem_Click;
            // 
            // addSilenceAsNewToolStripMenuItem
            // 
            addSilenceAsNewToolStripMenuItem.Name = "addSilenceAsNewToolStripMenuItem";
            addSilenceAsNewToolStripMenuItem.Size = new Size(190, 22);
            addSilenceAsNewToolStripMenuItem.Text = "Add Silence as New";
            addSilenceAsNewToolStripMenuItem.Click += addSilenceAsNewToolStripMenuItem_Click;
            // 
            // menuGenGradientNoise
            // 
            menuGenGradientNoise.Name = "menuGenGradientNoise";
            menuGenGradientNoise.Size = new Size(190, 22);
            menuGenGradientNoise.Text = "Gradient Noise";
            menuGenGradientNoise.Click += menuGenGradientNoise_Click;
            // 
            // colorThemeToolStripMenuItem
            // 
            colorThemeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkToolStripMenuItem, lightToolStripMenuItem });
            colorThemeToolStripMenuItem.Name = "colorThemeToolStripMenuItem";
            colorThemeToolStripMenuItem.Size = new Size(88, 20);
            colorThemeToolStripMenuItem.Text = "Color Theme";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(101, 22);
            darkToolStripMenuItem.Text = "Dark";
            darkToolStripMenuItem.Click += darkToolStripMenuItem_Click;
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new Size(101, 22);
            lightToolStripMenuItem.Text = "Light";
            lightToolStripMenuItem.Click += lightToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(53, 20);
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
            btnPlay.Location = new Point(25, 7);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(93, 93);
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
            trkDrawTimescale.Location = new Point(13, 19);
            trkDrawTimescale.Maximum = 1000;
            trkDrawTimescale.Minimum = 1;
            trkDrawTimescale.Name = "trkDrawTimescale";
            trkDrawTimescale.Size = new Size(1502, 45);
            trkDrawTimescale.SmallChange = 10;
            trkDrawTimescale.TabIndex = 7;
            trkDrawTimescale.TickFrequency = 10;
            trkDrawTimescale.Value = 500;
            trkDrawTimescale.Scroll += trkDrawTimescale_Scroll;
            // 
            // LoopEnableButton
            // 
            LoopEnableButton.BackColor = Color.Red;
            LoopEnableButton.Location = new Point(150, 18);
            LoopEnableButton.Name = "LoopEnableButton";
            LoopEnableButton.Size = new Size(101, 78);
            LoopEnableButton.TabIndex = 8;
            LoopEnableButton.Text = "loop";
            LoopEnableButton.UseVisualStyleBackColor = false;
            LoopEnableButton.Click += LoopEnableButton_Click;
            // 
            // pnlTrackBackground
            // 
            pnlTrackBackground.AutoSize = true;
            pnlTrackBackground.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlTrackBackground.BackColor = Color.FromArgb(41, 55, 71);
            pnlTrackBackground.Controls.Add(panTracks);
            pnlTrackBackground.Controls.Add(trkDrawTimescale);
            pnlTrackBackground.Location = new Point(47, 52);
            pnlTrackBackground.Name = "pnlTrackBackground";
            pnlTrackBackground.Size = new Size(1518, 581);
            pnlTrackBackground.TabIndex = 9;
            // 
            // pnlButtonBackground
            // 
            pnlButtonBackground.BackColor = Color.FromArgb(41, 55, 71);
            pnlButtonBackground.Controls.Add(btnPlay);
            pnlButtonBackground.Controls.Add(LoopEnableButton);
            pnlButtonBackground.Location = new Point(740, 667);
            pnlButtonBackground.Name = "pnlButtonBackground";
            pnlButtonBackground.Size = new Size(266, 110);
            pnlButtonBackground.TabIndex = 10;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 16, 24);
            BackgroundImage = Properties.Resources.backgroundTexture;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1604, 789);
            Controls.Add(pnlButtonBackground);
            Controls.Add(pnlTrackBackground);
            Controls.Add(lblDebug);
            Controls.Add(menu);
            DoubleBuffered = true;
            KeyPreview = true;
            MainMenuStrip = menu;
            Name = "FrmMain";
            Text = "Mediocre Sound Designer";
            SizeChanged += FrmMain_SizeChanged;
            panTracks.ResumeLayout(false);
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkDrawTimescale).EndInit();
            pnlTrackBackground.ResumeLayout(false);
            pnlTrackBackground.PerformLayout();
            pnlButtonBackground.ResumeLayout(false);
            pnlButtonBackground.PerformLayout();
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
        private ToolStripMenuItem colorThemeToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem;
        private Panel pnlTrackBackground;
        private Panel pnlButtonBackground;
    }
}
