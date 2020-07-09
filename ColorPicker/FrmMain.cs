using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class FrmMain : Form
    {
        private Bitmap img = (Bitmap)Properties.Resources.ColorWheel1.Clone();
        private Bitmap bkg = new Bitmap(256, 160);
        private Color cColor = Color.Transparent;
        private Pen cPen = new Pen(Color.DimGray, 2);
        private Point cPoint = new Point(255, 255);

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CreateBackground();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog() { Filter = "Image Files (*.bmp;*.jpg;*.png;*.ico)|*.bmp;*.jpg;*.png;*.ico|All files (*.*)|*.*" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                CreatePreview(dlg.FileName);
                picPanel.Refresh();
            }
        }

        private void BtnDefault1_Click(object sender, EventArgs e)
        {
            img = (Bitmap)Properties.Resources.ColorWheel1.Clone();
            picPanel.Refresh();
        }


        private void BtnDefault2_Click(object sender, EventArgs e)
        {
            img = (Bitmap)Properties.Resources.ColorWheel2.Clone();
            picPanel.Refresh();
        }

        private void PicPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.DrawImage(img, 0, 0);
            e.Graphics.DrawEllipse(cPen, cPoint.X - 5, cPoint.Y - 5, 10, 10);
        }

        private void PicSample_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.CompositingMode = CompositingMode.SourceOver;
            e.Graphics.DrawImage(bkg, 0, 0);
            e.Graphics.FillRectangle(new SolidBrush(cColor), 32, 32, 192, 96);
        }

        private void PicAlpha_Paint(object sender, PaintEventArgs e)
        {
            var sColor = Color.FromArgb(0, cColor.R, cColor.G, cColor.B);
            var eColor = Color.FromArgb(255, cColor.R, cColor.G, cColor.B);
            var aBrush = new LinearGradientBrush(new Point(0, 0), new Point(255, 0), sColor, eColor);
            e.Graphics.Clear(Color.White);
            e.Graphics.FillRectangle(aBrush, 0, 0, 256, 32);
        }

        private void PicPanel_MouseDown(object sender, MouseEventArgs e)
        {
            picPanel.MouseMove += new MouseEventHandler(PicPanel_MouseMove);
        }

        private void PicPanel_MouseMove(object sender, MouseEventArgs e)
        {
            cPoint = e.Location;
            UpdateColor();
        }

        private void PicPanel_MouseUp(object sender, MouseEventArgs e)
        {
            picPanel.MouseMove -= new MouseEventHandler(PicPanel_MouseMove);
            cPoint = e.Location;
            UpdateColor();
        }

        private void trbAlpha_ValueChanged(object sender, EventArgs e)
        {
            cColor = Color.FromArgb(trbAlpha.Value, cColor.R, cColor.G, cColor.B);
            UpdateTextBox();
            picSample.Refresh();
        }

        private void CreateBackground()
        {
            int t = 16;
            using (var g = Graphics.FromImage(bkg))
            {
                for (int x = 0; x < 256 / t; x++)
                {
                    for (int y = 0; y < 160 / t; y++)
                    {
                        if ((x + y) % 2 == 0)
                            g.FillRectangle(Brushes.LightGray, x * t, y * t, t, t);
                    }
                }
            }
        }

        private void CreatePreview(string file)
        {
            img = new Bitmap(512, 512);
            var bmp = (Image)Image.FromFile(file).Clone();
            int imgX = 0, imgY = 0;
            int imgW = 512, imgH = 512;
            if (bmp.Width > bmp.Height)
            {
                imgH = 512 * bmp.Height / bmp.Width;
                imgY = (512 - imgH) / 2;
            }
            else
            {
                imgW = 512 * bmp.Width / bmp.Height;
                imgX = (512 - imgW) / 2;
            }
            using (var g = Graphics.FromImage(img))
            {
                g.InterpolationMode = InterpolationMode.High;
                g.CompositingMode = CompositingMode.SourceOver;
                int t = 32;
                for (int x = 0; x < 512 / t; x++)
                {
                    for (int y = 0; y < 512 / t; y++)
                    {
                        if ((x + y) % 2 == 0)
                            g.FillRectangle(Brushes.LightGray, x * t, y * t, t, t);
                    }
                }
                g.DrawImage(bmp, new Rectangle(imgX, imgY, imgW, imgH), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
            }
        }

        private void UpdateColor()
        {
            if (cPoint.X < 0 || cPoint.Y < 0 || cPoint.X > 511 || cPoint.Y > 511)
                return;
            Color c = img.GetPixel(cPoint.X, cPoint.Y);
            cColor = Color.FromArgb(trbAlpha.Value, c.R, c.G, c.B);
            UpdateTextBox();
            picPanel.Refresh();
            picSample.Refresh();
            picAlpha.Refresh();
        }

        private void UpdateTextBox()
        {
            txtAlpha.Text = cColor.A.ToString();
            txtAlphaHex.Text = cColor.A.ToString("X2");
            txtRed.Text = cColor.R.ToString();
            txtRedHex.Text = cColor.R.ToString("X2");
            txtGreen.Text = cColor.G.ToString();
            txtGreenHex.Text = cColor.G.ToString("X2");
            txtBlue.Text = cColor.B.ToString();
            txtBlueHex.Text = cColor.B.ToString("X2");
            txtRGBA.Text = $"{cColor.R}, {cColor.G}, {cColor.B}, {cColor.A}";
            txtHEX.Text = $"#{cColor.A:X2}{cColor.R:X2}{cColor.G:X2}{cColor.B:X2}";
            txtHSB.Text = $"{cColor.GetHue():F3}, {cColor.GetSaturation():F3}, {cColor.GetBrightness():F3}";
        }
    }
}
