//Muhammed Emin Berkay KOCAOĞLU 201513171070

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErosionDilation
{
    public partial class ErosionveDilation : Form
    {
        public ErosionveDilation()
        {
            InitializeComponent();
        }
        Bitmap bmp = new Bitmap(300, 300);
        private void ErosionveDilation_Load(object sender, EventArgs e)
        {

            if (pictureBox1 != null)
            {
                try
                {
                    bmp = (Bitmap)Bitmap.FromFile(@"sekiller.jpg");
                    openFileDialog1.FileName = @"sekiller.jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = bmp;

                }
                catch (Exception)
                {
                    MessageBox.Show("Dosya bulunamadı.");
                }
                this.Refresh();
            }
        }

        private void buttonResimYukle_Click(object sender, EventArgs e)
        {
            if (pictureBox1 != null)
            {
                try
                {
                    openFileDialog1.ShowDialog();
                    pictureBox1.ImageLocation = openFileDialog1.FileName;
                    bmp = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                catch (Exception)
                {
                    MessageBox.Show("Dosya bulunamadı.");
                }
            }
        }
        private int RGBOrtalama(int y, int x)
        {
            Color c = bmp.GetPixel(x, y);

            int r = c.R;
            int g = c.G;
            int b = c.B;
            int avg = (r + g + b) / 3;
            return avg;
        }

        private void radioButtonRGB_CheckedChanged(object sender, EventArgs e)
        {
            if (bmp != null)
            {

                bmp = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = bmp;
                this.Refresh();
            }
        }

        private void radioButtonGrayScale_CheckedChanged(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(RGBOrtalama(y, x), RGBOrtalama(y, x), RGBOrtalama(y, x)));
                    }
                }

                pictureBox1.Image = bmp;
                this.Refresh();
            }
        }

        private void radioButtonBitmap_CheckedChanged(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);

                        int r = c.R;
                        int g = c.G;
                        int b = c.B;

                        if ((r + g + b) / 3 > Convert.ToInt32(numericUpDownDeger.Text))
                        {
                            bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }
                        else
                            bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
                pictureBox1.Image = bmp;
                this.Refresh();
            }
        }

        private void buttonErosion_Click(object sender, EventArgs e)
        {
            int[,] xyler = new int[bmp.Height, bmp.Width];
            int b1, b2, b3, b4, b5;
            Color cl;
            for (int x = 1; x < bmp.Height-1; x++)
            {
                for (int y = 1; y < bmp.Width-1; y++)
                {
                    cl = bmp.GetPixel(x, y);
                    b1 = cl.R;
                    if(b1 == 255)
                    {
                        cl = bmp.GetPixel(x - 1, y);
                        b2 = cl.R;
                        cl = bmp.GetPixel(x + 1, y);
                        b3 = cl.R;
                        cl = bmp.GetPixel(x, y - 1);
                        b4 = cl.R;
                        cl = bmp.GetPixel(x, y + 1);
                        b5 = cl.R;
                        if (b2 == 255 && b3 == 255 && b4 == 255 && b5 == 255)
                        {
                            xyler[x, y] = 255;
                        }
                        else
                        {
                            xyler[x, y] = 0;
                        }
                    }
                    
                }
            }
            for (int x = 1; x < bmp.Height - 1; x++)
            {
                for (int y = 1; y < bmp.Width - 1; y++)
                {
                    if (xyler[x, y] == 255)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));

                }
            }
                    pictureBox1.Image = bmp;
            this.Refresh();
        }

        private void buttonDilation_Click(object sender, EventArgs e)
        {
            int[,] xyler = new int[bmp.Height, bmp.Width];
            int b1, b2, b3, b4, b5;
            Color cl;
            for (int x = 1; x < bmp.Height - 1; x++)
            {
                for (int y = 1; y < bmp.Width - 1; y++)
                {
                    
                    cl = bmp.GetPixel(x, y);
                    b1 = cl.R;
                    cl = bmp.GetPixel(x - 1, y);
                    b2 = cl.R;
                    cl = bmp.GetPixel(x + 1, y);
                    b3 = cl.R;
                    cl = bmp.GetPixel(x, y - 1);
                    b4 = cl.R;
                    cl = bmp.GetPixel(x, y + 1);
                    b5 = cl.R;
                    if (b2 == 255 || b3 == 255 || b4 == 255 || b5 == 255)
                    {
                        xyler[x, y] = 255;
                    }
                    else
                    {
                        xyler[x, y] = 0;
                    }   
                }
            }
            for (int x = 1; x < bmp.Height - 1; x++)
            {
                for (int y = 1; y < bmp.Width - 1; y++)
                {
                    if (xyler[x, y] == 255)
                    {
                        bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));

                }
            }
            pictureBox1.Image = bmp;
            this.Refresh();
        }

        private void buttonTersSimetri_Click(object sender, EventArgs e)
        {
            
            for (int x = 0; x < bmp.Height/2; x++)
            {
                for (int y = 0; y < bmp.Width; y++)
                {
                    Color cl = bmp.GetPixel(x, y);
                    Color tmp = bmp.GetPixel(bmp.Height - x - 1, y);
                    bmp.SetPixel(x, y, tmp);
                    bmp.SetPixel(bmp.Height - x - 1, y, cl);
                }
            }

            pictureBox1.Image = bmp;
            this.Refresh();
        }

        private void buttonSetPikselArti_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);

                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    if (r <= 255)
                    {
                        if (r >= 230)
                        {
                            r = 255;
                        }
                        else r += 25;
                    }
                    if (g <= 255)
                    {
                        if (g >= 230)
                        {
                            g = 255;
                        }
                        else g += 25;
                    }
                    if (b <= 255)
                    {
                        if (b >= 230)
                        {
                            b = 255;
                        }
                        else b += 25;
                    }
                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
                   
            pictureBox1.Image = bmp;
            this.Refresh();
        }

        private void buttonSetPikselEksi_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);

                    int r = c.R;
                    int g = c.G;
                    int b = c.B;

                    if (r >= 0)
                    {
                        if (r <= 25)
                        {
                            r = 0;
                        }
                        else r -= 25;
                    }
                    if (g >= 0)
                    {
                        if (g <= 25)
                        {
                            g = 0;
                        }
                        else g -= 25;
                    }
                    if (b >= 0)
                    {
                        if (b <= 25)
                        {
                            b = 0;
                        }
                        else b -= 25;
                    }
                    bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            pictureBox1.Image = bmp;
            this.Refresh();
        }
    }
}
//Muhammed Emin Berkay KOCAOĞLU 201513171070
