using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ImageProcessingActivity
{
    public partial class Form1 : Form
    {
        Bitmap loadedImage;
        Bitmap resultImage;
        Bitmap histoImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Histogram(ref Bitmap a, ref Bitmap b)
        {
            Color sample;
            Color gray;
            Byte graydata;

            // Grayscale Conversion
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    graydata = (byte)((sample.R + sample.G + sample.B) / 3);
                    gray = Color.FromArgb(graydata, graydata, graydata);
                    a.SetPixel(x, y, gray);
                }
            }

            // Histogram 1D data
            int[] histdata = new int[256]; 
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    histdata[sample.R]++; // can be any color property r, g, or b
                }
            }

            // Bitmap Graph Generation
            // Setting empty Bitmap with background color
            b = new Bitmap(histdata.Length, 800);
            for (int x = 0; x < histdata.Length; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    b.SetPixel(x, y, Color.White);
                }
            }

            // Plotting points based on histdata
            for (int x = 0; x < histdata.Length; x++)
            {
                for (int y = 0; y < Math.Min(histdata[x] / 5, b.Height - 1); y++)
                {
                    b.SetPixel(x, (b.Height - 1) - y, Color.Black);
                }
            }

            imageHistogram.Image = b;
        }


        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            for (int x=0; x<resultImage.Width; x++)
            {
                for(int y=0; y<resultImage.Height; y++)
                {
                    Color pixel = loadedImage.GetPixel(x, y);
                    resultImage.SetPixel(x, y, pixel);
                }
            }
            processedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            processedImage.Image = resultImage;
            UpdateHistogram();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
           // Histogram(ref loadedImage, ref histoImage);

            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loadedImage = new Bitmap(openFileDialog1.FileName);
            orignalImage.Image = loadedImage;


        }

        private void greyScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            for (int x = 0; x < resultImage.Width; x++)
            {
                for (int y = 0; y < resultImage.Height; y++)
                {
                    Color pixel = loadedImage.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    resultImage.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            }
            processedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            processedImage.Image = resultImage;
            UpdateHistogram();
        }

        private void colorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            for (int x = 0; x < resultImage.Width; x++)
            {
                for (int y = 0; y < resultImage.Height; y++)
                {
                    Color pixel = loadedImage.GetPixel(x, y);
                    resultImage.SetPixel(x, y, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B)); 
                }
            }
            processedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            processedImage.Image = resultImage;
            UpdateHistogram();
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultImage = new Bitmap(loadedImage.Width, loadedImage.Height);
            for (int x = 0; x < resultImage.Width; x++)
            {
                for (int y = 0; y < resultImage.Height; y++)
                {
                    Color pixel = loadedImage.GetPixel(x, y);

                    int sepiaIntensity = 20;

                    int newRed = (int)(pixel.R * 0.393 + pixel.G * 0.769 + pixel.B * 0.189);
                    int newGreen = (int)(pixel.R * 0.349 + pixel.G * 0.686 + pixel.B * 0.168);
                    int newBlue = (int)(pixel.R * 0.272 + pixel.G * 0.534 + pixel.B * 0.131);

                    newRed = Math.Min(255, newRed + sepiaIntensity);
                    newGreen = Math.Min(255, newGreen + sepiaIntensity);
                    newBlue = Math.Min(255, newBlue + sepiaIntensity);

                    resultImage.SetPixel(x, y, Color.FromArgb(newRed, newGreen, newBlue));
                }
            }
            processedImage.SizeMode = PictureBoxSizeMode.StretchImage;
            processedImage.Image = resultImage;
            UpdateHistogram();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!showHistogram.Checked)
            {
                // Clear the histogram picture box
                imageHistogram.Image = null; 
            }
            else
            {
                // Show the histogram
                Histogram(ref resultImage, ref histoImage);
            }
        }
        private void UpdateHistogram()
        {
            if (showHistogram.Checked)
            {
                Histogram(ref resultImage, ref histoImage);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
