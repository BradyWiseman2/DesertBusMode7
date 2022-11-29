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
            this.pBoxRender = new System.Windows.Forms.PictureBox();
            this.timerRender = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRender)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxRender
            // 
            this.pBoxRender.BackColor = System.Drawing.Color.Black;
            this.pBoxRender.Location = new System.Drawing.Point(-3, 171);
            this.pBoxRender.Name = "pBoxRender";
            this.pBoxRender.Size = new System.Drawing.Size(1258, 488);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1252, 565);
            this.Controls.Add(this.pBoxRender);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pBoxRender;
        private System.Windows.Forms.Timer timerRender;
    }
}