using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using HNUDIP;
using WebCamLib;
using Image = System.Drawing.Image;

namespace ImageProcessingActivity
{    
  
    public partial class Form1 : Form
    {
        Bitmap loadedImage, backgroundImage, colorGreen;
        Bitmap resultImage;
        Bitmap resultImageBackground;
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

            // Create a copy of the original image
            Bitmap originalCopy = new Bitmap(a);

            // Grayscale Conversion
            for (int x = 0; x < originalCopy.Width; x++)
            {
                for (int y = 0; y < originalCopy.Height; y++)
                {
                    sample = originalCopy.GetPixel(x, y);
                    graydata = (byte)((sample.R + sample.G + sample.B) / 3);
                    gray = Color.FromArgb(graydata, graydata, graydata);
                    originalCopy.SetPixel(x, y, gray);
                }
            }

            // Histogram 1D data
            int[] histdata = new int[256];
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    histdata[sample.G]++; // can be any color property r, g, or b
                }
            }

            // Bitmap Graph Generation
            // Setting empty Bitmap with background color
            b = new Bitmap(256, 800);
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
                for (int y = 0; y < Math.Min(histdata[x] / 5, 800); y++)
                {
                    b.SetPixel(x, 799  - y, Color.Black);
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
            if (showHistogram.Checked && processedImage.Image != null)
            {
                // Clear the histogram picture box
                Histogram(ref resultImage, ref histoImage);
                
            }
            if(!showHistogram.Checked)
            {
                // Show the histogram
                imageHistogram.Image = null;
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
        
            backgroundImage = new Bitmap(openFileDialog2.FileName);
            loadBackgroundImageBox.Image = backgroundImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color myGreen = Color.FromArgb(0, 255, 0);
            int greyGreen = (myGreen.R + myGreen.G + myGreen.B) / 3;
            int threshold = 5;

            colorGreen = new Bitmap(backgroundImage.Width, backgroundImage.Width);

            for (int x = 0; x < loadedImage.Width; x++)
            {
                for (int y = 0; y < loadedImage.Height; y++)
                {
                    Color pixel = loadedImage.GetPixel(x, y);
                    Color backPixel = backgroundImage.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey - greyGreen);

                    if (subtractvalue > threshold)

                        colorGreen.SetPixel(x, y, pixel);
                    else
                       colorGreen.SetPixel(x, y, backPixel);

                }
                
            }
            subtractedImage.Image = colorGreen;

        }
        Device[] devices = DeviceManager.GetAllDevices();
        Device cam = DeviceManager.GetDevice(0);
        Boolean isSubtract = false;


        private void camSubtract_Click(object sender, EventArgs e)
        {
            isSubtract = !isSubtract;
            IDataObject data;
            Image bmap;
            devices[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));

            if (backgroundImage != null && bmap.Size == backgroundImage.Size)
            {
                timer1.Enabled = isSubtract;
                label7.Visible = false;
            }
            else if (backgroundImage == null)
            {
                Console.WriteLine("Background is null");
            }
            else

            {
                label7.Visible = true;
                Console.WriteLine(backgroundImage.Size);
                Console.WriteLine(backgroundImage.Size);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            IDataObject data;
            Image bmap;
            devices[0].Sendmessage();
            data = Clipboard.GetDataObject();

            int threshold = 100;

            if (data != null)
            {
                bmap = (Image)(data.GetData("System.Drawing.Bitmap", true));

                // Check if the retrieved data is a valid image
                if (bmap != null)
                {
                    Bitmap b = new Bitmap(bmap);

                    ImageProcess2.BitmapFilter.Subtract(b, backgroundImage, Color.Green, threshold);

                    subtractedImage.Image = b;
                }
                else
                {
                    // Handle case where clipboard data is not a valid image
                    Console.WriteLine("Clipboard data is not a valid image.");
                }
            }
            else
            {
                // Handle case where clipboard data is not available
                Console.WriteLine("Clipboard data is not available.");
            }
        }



        private void cameraButton_Click(object sender, EventArgs e)
        {

            cam.ShowWindow(orignalImage);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (processedImage.Image != null)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the file name from the dialog
                    string fileName = saveDialog.FileName;

                    // Determine the file format based on the chosen filter
                    ImageFormat format = ImageFormat.Jpeg; // Default to JPEG
                    string ext = System.IO.Path.GetExtension(fileName);
                    switch (ext.ToLower())
                    {
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                        case ".gif":
                            format = ImageFormat.Gif;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                    }

                    // Save the image
                    processedImage.Image.Save(fileName, format);
                }
            }
            else
            {
                MessageBox.Show("No image to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
