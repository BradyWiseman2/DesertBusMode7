namespace DesertBusMode7
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pBoxRender = new System.Windows.Forms.PictureBox();
            this.timerRender = new System.Windows.Forms.Timer(this.components);
            this.pBoxTransition = new System.Windows.Forms.PictureBox();
            this.timerTimeDriven = new System.Windows.Forms.Timer(this.components);
            this.pBoxWin = new System.Windows.Forms.PictureBox();
            this.pBoxTitle = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.btnMapViewer = new System.Windows.Forms.PictureBox();
            this.pBoxDesert = new System.Windows.Forms.PictureBox();
            this.pBoxCastle = new System.Windows.Forms.PictureBox();
            this.pBoxBeach = new System.Windows.Forms.PictureBox();
            this.pBoxChocoMt = new System.Windows.Forms.PictureBox();
            this.pBoxLake = new System.Windows.Forms.PictureBox();
            this.pBoxRainbowRoad = new System.Windows.Forms.PictureBox();
            this.pBoxGhost = new System.Windows.Forms.PictureBox();
            this.pBoxPlains = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTransition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMapViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDesert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCastle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBeach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxChocoMt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRainbowRoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlains)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxRender
            // 
            this.pBoxRender.BackColor = System.Drawing.Color.Black;
            this.pBoxRender.Location = new System.Drawing.Point(-5, 179);
            this.pBoxRender.Name = "pBoxRender";
            this.pBoxRender.Size = new System.Drawing.Size(1114, 341);
            this.pBoxRender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxRender.TabIndex = 0;
            this.pBoxRender.TabStop = false;
            // 
            // timerRender
            // 
            this.timerRender.Enabled = true;
            this.timerRender.Interval = 10;
            this.timerRender.Tick += new System.EventHandler(this.timerRender_Tick);
            // 
            // pBoxTransition
            // 
            this.pBoxTransition.BackColor = System.Drawing.Color.Black;
            this.pBoxTransition.Location = new System.Drawing.Point(-1201, 0);
            this.pBoxTransition.Name = "pBoxTransition";
            this.pBoxTransition.Size = new System.Drawing.Size(1200, 582);
            this.pBoxTransition.TabIndex = 1;
            this.pBoxTransition.TabStop = false;
            // 
            // timerTimeDriven
            // 
            this.timerTimeDriven.Interval = 1000;
            this.timerTimeDriven.Tick += new System.EventHandler(this.timerTimeDriven_Tick);
            // 
            // pBoxWin
            // 
            this.pBoxWin.Enabled = false;
            this.pBoxWin.Image = global::DesertBusMode7.Properties.Resources.Big_Rigs_Over_the_Road_Racing_trophy;
            this.pBoxWin.Location = new System.Drawing.Point(1038, 215);
            this.pBoxWin.Name = "pBoxWin";
            this.pBoxWin.Size = new System.Drawing.Size(217, 179);
            this.pBoxWin.TabIndex = 2;
            this.pBoxWin.TabStop = false;
            this.pBoxWin.Visible = false;
            // 
            // pBoxTitle
            // 
            this.pBoxTitle.Image = global::DesertBusMode7.Properties.Resources.map_1_;
            this.pBoxTitle.Location = new System.Drawing.Point(283, 12);
            this.pBoxTitle.Name = "pBoxTitle";
            this.pBoxTitle.Size = new System.Drawing.Size(531, 82);
            this.pBoxTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxTitle.TabIndex = 3;
            this.pBoxTitle.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Image = global::DesertBusMode7.Properties.Resources.Start;
            this.btnStart.Location = new System.Drawing.Point(159, 128);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(244, 45);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart.TabIndex = 4;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnMapViewer
            // 
            this.btnMapViewer.Image = global::DesertBusMode7.Properties.Resources.Map_Viewer;
            this.btnMapViewer.Location = new System.Drawing.Point(572, 128);
            this.btnMapViewer.Name = "btnMapViewer";
            this.btnMapViewer.Size = new System.Drawing.Size(374, 45);
            this.btnMapViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMapViewer.TabIndex = 5;
            this.btnMapViewer.TabStop = false;
            this.btnMapViewer.Click += new System.EventHandler(this.btnMapViewer_Click);
            // 
            // pBoxDesert
            // 
            this.pBoxDesert.Enabled = false;
            this.pBoxDesert.Image = global::DesertBusMode7.Properties.Resources.DesertMain;
            this.pBoxDesert.Location = new System.Drawing.Point(121, 239);
            this.pBoxDesert.Name = "pBoxDesert";
            this.pBoxDesert.Size = new System.Drawing.Size(103, 186);
            this.pBoxDesert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxDesert.TabIndex = 8;
            this.pBoxDesert.TabStop = false;
            this.pBoxDesert.Visible = false;
            this.pBoxDesert.Click += new System.EventHandler(this.pBoxDesert_Click);
            // 
            // pBoxCastle
            // 
            this.pBoxCastle.Enabled = false;
            this.pBoxCastle.Image = global::DesertBusMode7.Properties.Resources.BowserCastleMain;
            this.pBoxCastle.Location = new System.Drawing.Point(775, 239);
            this.pBoxCastle.Name = "pBoxCastle";
            this.pBoxCastle.Size = new System.Drawing.Size(103, 186);
            this.pBoxCastle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxCastle.TabIndex = 9;
            this.pBoxCastle.TabStop = false;
            this.pBoxCastle.Visible = false;
            this.pBoxCastle.Click += new System.EventHandler(this.pBoxCastle_Click);
            // 
            // pBoxBeach
            // 
            this.pBoxBeach.Enabled = false;
            this.pBoxBeach.Image = global::DesertBusMode7.Properties.Resources.KoopaBeachMain;
            this.pBoxBeach.Location = new System.Drawing.Point(448, 239);
            this.pBoxBeach.Name = "pBoxBeach";
            this.pBoxBeach.Size = new System.Drawing.Size(103, 186);
            this.pBoxBeach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxBeach.TabIndex = 10;
            this.pBoxBeach.TabStop = false;
            this.pBoxBeach.Visible = false;
            this.pBoxBeach.Click += new System.EventHandler(this.pBoxBeach_Click);
            // 
            // pBoxChocoMt
            // 
            this.pBoxChocoMt.Enabled = false;
            this.pBoxChocoMt.Image = global::DesertBusMode7.Properties.Resources.ChocoMtMain;
            this.pBoxChocoMt.Location = new System.Drawing.Point(339, 239);
            this.pBoxChocoMt.Name = "pBoxChocoMt";
            this.pBoxChocoMt.Size = new System.Drawing.Size(103, 186);
            this.pBoxChocoMt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxChocoMt.TabIndex = 11;
            this.pBoxChocoMt.TabStop = false;
            this.pBoxChocoMt.Visible = false;
            this.pBoxChocoMt.Click += new System.EventHandler(this.pBoxChocoMt_Click);
            // 
            // pBoxLake
            // 
            this.pBoxLake.Enabled = false;
            this.pBoxLake.Image = global::DesertBusMode7.Properties.Resources.VanillaLakeMain;
            this.pBoxLake.Location = new System.Drawing.Point(557, 239);
            this.pBoxLake.Name = "pBoxLake";
            this.pBoxLake.Size = new System.Drawing.Size(103, 186);
            this.pBoxLake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxLake.TabIndex = 12;
            this.pBoxLake.TabStop = false;
            this.pBoxLake.Visible = false;
            this.pBoxLake.Click += new System.EventHandler(this.pBoxLake_Click);
            // 
            // pBoxRainbowRoad
            // 
            this.pBoxRainbowRoad.Enabled = false;
            this.pBoxRainbowRoad.Image = global::DesertBusMode7.Properties.Resources.RainbowRoadMain;
            this.pBoxRainbowRoad.Location = new System.Drawing.Point(884, 239);
            this.pBoxRainbowRoad.Name = "pBoxRainbowRoad";
            this.pBoxRainbowRoad.Size = new System.Drawing.Size(103, 186);
            this.pBoxRainbowRoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxRainbowRoad.TabIndex = 13;
            this.pBoxRainbowRoad.TabStop = false;
            this.pBoxRainbowRoad.Visible = false;
            this.pBoxRainbowRoad.Click += new System.EventHandler(this.pBoxRainbowRoad_Click);
            // 
            // pBoxGhost
            // 
            this.pBoxGhost.Enabled = false;
            this.pBoxGhost.Image = global::DesertBusMode7.Properties.Resources.GhostValleyMain;
            this.pBoxGhost.Location = new System.Drawing.Point(666, 239);
            this.pBoxGhost.Name = "pBoxGhost";
            this.pBoxGhost.Size = new System.Drawing.Size(103, 186);
            this.pBoxGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxGhost.TabIndex = 14;
            this.pBoxGhost.TabStop = false;
            this.pBoxGhost.Visible = false;
            this.pBoxGhost.Click += new System.EventHandler(this.pBoxGhost_Click);
            // 
            // pBoxPlains
            // 
            this.pBoxPlains.Enabled = false;
            this.pBoxPlains.Image = global::DesertBusMode7.Properties.Resources.DonutPlainsMain;
            this.pBoxPlains.Location = new System.Drawing.Point(230, 239);
            this.pBoxPlains.Name = "pBoxPlains";
            this.pBoxPlains.Size = new System.Drawing.Size(103, 186);
            this.pBoxPlains.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxPlains.TabIndex = 15;
            this.pBoxPlains.TabStop = false;
            this.pBoxPlains.Visible = false;
            this.pBoxPlains.Click += new System.EventHandler(this.pBoxPlains_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1100, 514);
            this.Controls.Add(this.pBoxPlains);
            this.Controls.Add(this.pBoxGhost);
            this.Controls.Add(this.pBoxRainbowRoad);
            this.Controls.Add(this.pBoxLake);
            this.Controls.Add(this.pBoxChocoMt);
            this.Controls.Add(this.pBoxBeach);
            this.Controls.Add(this.pBoxCastle);
            this.Controls.Add(this.pBoxDesert);
            this.Controls.Add(this.btnMapViewer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pBoxTitle);
            this.Controls.Add(this.pBoxTransition);
            this.Controls.Add(this.pBoxRender);
            this.Controls.Add(this.pBoxWin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Super Desert Kart";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTransition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMapViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDesert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxCastle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxBeach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxChocoMt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRainbowRoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPlains)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pBoxRender;
        private System.Windows.Forms.Timer timerRender;
        private PictureBox pBoxTransition;
        private System.Windows.Forms.Timer timerTimeDriven;
        private PictureBox pBoxWin;
        private PictureBox pBoxTitle;
        private PictureBox btnStart;
        private PictureBox btnMapViewer;
        private PictureBox pBoxDesert;
        private PictureBox pBoxCastle;
        private PictureBox pBoxBeach;
        private PictureBox pBoxChocoMt;
        private PictureBox pBoxLake;
        private PictureBox pBoxRainbowRoad;
        private PictureBox pBoxGhost;
        private PictureBox pBoxPlains;
    }
}