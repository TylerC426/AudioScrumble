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
            alterSpeedToolStripMenuItem = new ToolStripMenuItem();
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
            btnPlayFromBeginning = new Button();
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
            panTracks.Paint += panTracks_Paint;
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
            lblDebug.BackColor = Color.Transparent;
            lblDebug.Dock = DockStyle.Bottom;
            lblDebug.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDebug.ForeColor = Color.FromArgb(255, 255, 192);
            lblDebug.Location = new Point(0, 752);
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
            menu.Items.AddRange(new ToolStripItem[] { menuFile, menuEdit, menuGen, colorThemeToolStripMenuItem, helpToolStripMenuItem });
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
            menuEdit.DropDownItems.AddRange(new ToolStripItem[] { menuEditUndo, menuEditRedo, toolStripSeparator1, menuEditFlip, menuEditReverse, menuEditVolume, alterSpeedToolStripMenuItem, menuEditEliminateSilence });
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
            // alterSpeedToolStripMenuItem
            // 
            alterSpeedToolStripMenuItem.Name = "alterSpeedToolStripMenuItem";
            alterSpeedToolStripMenuItem.Size = new Size(172, 22);
            alterSpeedToolStripMenuItem.Text = "Alter Speed...";
            alterSpeedToolStripMenuItem.Click += alterSpeedToolStripMenuItem_Click;
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
            addNoiseToTrackToolStripMenuItem.Size = new Size(190, 22);
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
            helpToolStripMenuItem.Size = new Size(77, 29);
            helpToolStripMenuItem.Text = "&Help...";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // btnPlay
            // 
            btnPlay.AutoSize = true;
            btnPlay.BackColor = Color.Transparent;
            btnPlay.BackgroundImage = Properties.Resources.playFromPause;
            btnPlay.BackgroundImageLayout = ImageLayout.Stretch;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPlay.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(132, 15);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(92, 81);
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
            LoopEnableButton.BackColor = Color.Transparent;
            LoopEnableButton.BackgroundImage = Properties.Resources.loopFalse;
            LoopEnableButton.BackgroundImageLayout = ImageLayout.Stretch;
            LoopEnableButton.FlatAppearance.BorderSize = 0;
            LoopEnableButton.FlatStyle = FlatStyle.Flat;
            LoopEnableButton.Location = new Point(265, 15);
            LoopEnableButton.Name = "LoopEnableButton";
            LoopEnableButton.Size = new Size(84, 81);
            LoopEnableButton.TabIndex = 8;
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
            pnlButtonBackground.Location = new Point(628, 667);
            pnlButtonBackground.Name = "pnlButtonBackground";
            pnlButtonBackground.Size = new Size(378, 110);
            pnlButtonBackground.TabIndex = 10;
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
            BackColor = Color.FromArgb(18, 16, 24);
            BackgroundImage = Properties.Resources.backgroundTexture;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1604, 789);
            Controls.Add(pnlButtonBackground);
            Controls.Add(pnlTrackBackground);
            Controls.Add(btnPlayFromBeginning);
            // Controls.Add(LoopEnableButton);
            // Controls.Add(trkDrawTimescale);
            // Controls.Add(btnPlay);
            Controls.Add(lblDebug);
            Controls.Add(menu);
            DoubleBuffered = true;
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
        private ToolStripMenuItem alterSpeedToolStripMenuItem;
        private ToolStripMenuItem menuEditUndo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuEditRedo;
        private Button btnPlayFromBeginning;
    }
}
