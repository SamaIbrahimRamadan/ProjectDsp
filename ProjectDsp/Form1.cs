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
using System.Windows.Forms.DataVisualization.Charting;
using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;




namespace ProjectDsp
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private double[] transformedSignal;
        public Form1()
        {
            InitializeComponent();
        }
        private double[] ConvertImageToSignal(Bitmap image)
        {
            int width = image.Width;
            int height = image.Height;
            double[] signal = new double[width * height];

            BitmapData bmpData = image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            IntPtr ptr = bmpData.Scan0;

            unsafe
            {
                byte* bytes = (byte*)ptr;

                for (int y = 0; y < height; y++)
                {
                    byte* row = bytes + (y * bmpData.Stride);

                    for (int x = 0; x < width; x++)
                    {
                        int offset = x * 3; // Assuming 24bpp RGB format

                        double intensity = (row[offset] + row[offset + 1] + row[offset + 2]) / 3.0; // Assuming grayscale intensity
                        signal[y * width + x] = intensity;
                    }
                }
            }

            image.UnlockBits(bmpData);

            return signal;
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog.FileName);
                picbox.Image = originalImage;
            }
        }

        private void LaplaceTransform_Click(object sender, EventArgs e)
        {
            double[] transformedSignal = PerformFT(originalImage);

            // Create an instance of the ChartForm and pass the magnitudes data
            Form2 chartForm = new Form2(transformedSignal);
            chartForm.Show();

        }

        private double[] PerformFT(Bitmap image)
        {
            // Convert the image to a 1D signal array
            double[] signal = ConvertImageToSignal(image);

            // Perform the Fourier transform on the signal using FFT
            Complex32[] complexSignal = new Complex32[signal.Length];
            for (int i = 0; i < signal.Length; i++)
            {
                complexSignal[i] = new Complex32((float)signal[i], 0);
            }
            Fourier.Forward(complexSignal, FourierOptions.Default);

            return complexSignal.Select(c => (double)c.Magnitude).ToArray();
        }

    }
}
