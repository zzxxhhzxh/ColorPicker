namespace ColorPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.txtAlpha = new System.Windows.Forms.TextBox();
            this.txtAlphaHex = new System.Windows.Forms.TextBox();
            this.txtRedHex = new System.Windows.Forms.TextBox();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.txtGreenHex = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtBlueHex = new System.Windows.Forms.TextBox();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trbAlpha = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHEX = new System.Windows.Forms.TextBox();
            this.txtHSB = new System.Windows.Forms.TextBox();
            this.txtRGBA = new System.Windows.Forms.TextBox();
            this.picAlpha = new System.Windows.Forms.PictureBox();
            this.picSample = new System.Windows.Forms.PictureBox();
            this.picPanel = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDefault1 = new System.Windows.Forms.Button();
            this.btnDefault2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAlpha
            // 
            this.txtAlpha.Location = new System.Drawing.Point(593, 365);
            this.txtAlpha.Name = "txtAlpha";
            this.txtAlpha.ReadOnly = true;
            this.txtAlpha.Size = new System.Drawing.Size(60, 20);
            this.txtAlpha.TabIndex = 8;
            // 
            // txtAlphaHex
            // 
            this.txtAlphaHex.Location = new System.Drawing.Point(659, 365);
            this.txtAlphaHex.Name = "txtAlphaHex";
            this.txtAlphaHex.ReadOnly = true;
            this.txtAlphaHex.Size = new System.Drawing.Size(60, 20);
            this.txtAlphaHex.TabIndex = 9;
            // 
            // txtRedHex
            // 
            this.txtRedHex.Location = new System.Drawing.Point(659, 287);
            this.txtRedHex.Name = "txtRedHex";
            this.txtRedHex.ReadOnly = true;
            this.txtRedHex.Size = new System.Drawing.Size(60, 20);
            this.txtRedHex.TabIndex = 3;
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(593, 287);
            this.txtRed.Name = "txtRed";
            this.txtRed.ReadOnly = true;
            this.txtRed.Size = new System.Drawing.Size(60, 20);
            this.txtRed.TabIndex = 2;
            // 
            // txtGreenHex
            // 
            this.txtGreenHex.Location = new System.Drawing.Point(659, 313);
            this.txtGreenHex.Name = "txtGreenHex";
            this.txtGreenHex.ReadOnly = true;
            this.txtGreenHex.Size = new System.Drawing.Size(60, 20);
            this.txtGreenHex.TabIndex = 5;
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(593, 313);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.ReadOnly = true;
            this.txtGreen.Size = new System.Drawing.Size(60, 20);
            this.txtGreen.TabIndex = 4;
            // 
            // txtBlueHex
            // 
            this.txtBlueHex.Location = new System.Drawing.Point(659, 339);
            this.txtBlueHex.Name = "txtBlueHex";
            this.txtBlueHex.ReadOnly = true;
            this.txtBlueHex.Size = new System.Drawing.Size(60, 20);
            this.txtBlueHex.TabIndex = 7;
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(593, 339);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.ReadOnly = true;
            this.txtBlue.Size = new System.Drawing.Size(60, 20);
            this.txtBlue.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 290);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(37, 169);
            this.label1.TabIndex = 8;
            this.label1.Text = "R\r\n\r\nG\r\n\r\nB\r\n\r\nA\r\n\r\nRGBA\r\n\r\nHEX\r\n\r\nHSB";
            // 
            // trbAlpha
            // 
            this.trbAlpha.LargeChange = 10;
            this.trbAlpha.Location = new System.Drawing.Point(542, 178);
            this.trbAlpha.Maximum = 255;
            this.trbAlpha.Name = "trbAlpha";
            this.trbAlpha.Size = new System.Drawing.Size(277, 45);
            this.trbAlpha.TabIndex = 1;
            this.trbAlpha.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbAlpha.Value = 255;
            this.trbAlpha.ValueChanged += new System.EventHandler(this.trbAlpha_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "RGB              HEX ";
            // 
            // txtHEX
            // 
            this.txtHEX.Location = new System.Drawing.Point(593, 418);
            this.txtHEX.Name = "txtHEX";
            this.txtHEX.ReadOnly = true;
            this.txtHEX.Size = new System.Drawing.Size(126, 20);
            this.txtHEX.TabIndex = 11;
            // 
            // txtHSB
            // 
            this.txtHSB.Location = new System.Drawing.Point(593, 444);
            this.txtHSB.Name = "txtHSB";
            this.txtHSB.ReadOnly = true;
            this.txtHSB.Size = new System.Drawing.Size(126, 20);
            this.txtHSB.TabIndex = 12;
            // 
            // txtRGBA
            // 
            this.txtRGBA.Location = new System.Drawing.Point(593, 392);
            this.txtRGBA.Name = "txtRGBA";
            this.txtRGBA.ReadOnly = true;
            this.txtRGBA.Size = new System.Drawing.Size(126, 20);
            this.txtRGBA.TabIndex = 10;
            // 
            // picAlpha
            // 
            this.picAlpha.Location = new System.Drawing.Point(550, 203);
            this.picAlpha.Name = "picAlpha";
            this.picAlpha.Size = new System.Drawing.Size(256, 32);
            this.picAlpha.TabIndex = 12;
            this.picAlpha.TabStop = false;
            this.picAlpha.Paint += new System.Windows.Forms.PaintEventHandler(this.PicAlpha_Paint);
            // 
            // picSample
            // 
            this.picSample.Location = new System.Drawing.Point(550, 12);
            this.picSample.Name = "picSample";
            this.picSample.Size = new System.Drawing.Size(256, 160);
            this.picSample.TabIndex = 11;
            this.picSample.TabStop = false;
            this.picSample.Paint += new System.Windows.Forms.PaintEventHandler(this.PicSample_Paint);
            // 
            // picPanel
            // 
            this.picPanel.Location = new System.Drawing.Point(12, 12);
            this.picPanel.Name = "picPanel";
            this.picPanel.Size = new System.Drawing.Size(512, 512);
            this.picPanel.TabIndex = 0;
            this.picPanel.TabStop = false;
            this.picPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PicPanel_Paint);
            this.picPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicPanel_MouseDown);
            this.picPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PicPanel_MouseUp);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(731, 285);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 14;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // btnDefault1
            // 
            this.btnDefault1.Location = new System.Drawing.Point(731, 311);
            this.btnDefault1.Name = "btnDefault1";
            this.btnDefault1.Size = new System.Drawing.Size(75, 23);
            this.btnDefault1.TabIndex = 15;
            this.btnDefault1.Text = "Default 1";
            this.btnDefault1.UseVisualStyleBackColor = true;
            this.btnDefault1.Click += new System.EventHandler(this.BtnDefault1_Click);
            // 
            // btnDefault2
            // 
            this.btnDefault2.Location = new System.Drawing.Point(731, 337);
            this.btnDefault2.Name = "btnDefault2";
            this.btnDefault2.Size = new System.Drawing.Size(75, 23);
            this.btnDefault2.TabIndex = 15;
            this.btnDefault2.Text = "Default 2";
            this.btnDefault2.UseVisualStyleBackColor = true;
            this.btnDefault2.Click += new System.EventHandler(this.BtnDefault2_Click);
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(818, 536);
            this.Controls.Add(this.btnDefault2);
            this.Controls.Add(this.btnDefault1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picAlpha);
            this.Controls.Add(this.picSample);
            this.Controls.Add(this.trbAlpha);
            this.Controls.Add(this.txtHSB);
            this.Controls.Add(this.txtHEX);
            this.Controls.Add(this.txtRGBA);
            this.Controls.Add(this.txtBlueHex);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.txtGreenHex);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.txtRedHex);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.txtAlphaHex);
            this.Controls.Add(this.txtAlpha);
            this.Controls.Add(this.picPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Color Picker";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picPanel;
        private System.Windows.Forms.TextBox txtAlpha;
        private System.Windows.Forms.TextBox txtAlphaHex;
        private System.Windows.Forms.TextBox txtRedHex;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.TextBox txtGreenHex;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtBlueHex;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbAlpha;
        private System.Windows.Forms.PictureBox picSample;
        private System.Windows.Forms.PictureBox picAlpha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHEX;
        private System.Windows.Forms.TextBox txtHSB;
        private System.Windows.Forms.TextBox txtRGBA;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDefault1;
        private System.Windows.Forms.Button btnDefault2;
    }
}