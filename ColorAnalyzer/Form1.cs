using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountColors()
        {
            int result = 0;
            
            List<Color> colors = new List<Color>();
            Color pixelColor;

            Bitmap picture = new Bitmap("test0.png");





            BitmapData bitmapData = picture.LockBits(new Rectangle(0, 0, picture.Width, picture.Height), ImageLockMode.ReadWrite, picture.PixelFormat);
            int BytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(picture.PixelFormat) / 8;
            int ByteCount = bitmapData.Stride * picture.Height;
            byte[] Pixels = new byte[ByteCount];
            IntPtr PtrFirstPixel = bitmapData.Scan0;
            Marshal.Copy(PtrFirstPixel, Pixels, 0, Pixels.Length);
            int HeightInPixels = bitmapData.Height;
            int WidthInBytes = bitmapData.Width * BytesPerPixel;
            for (int y = 0; y < HeightInPixels; y++)
            {
                int CurrentLine = y * bitmapData.Stride;
                for (int x = 0; x < WidthInBytes; x = x + BytesPerPixel)
                {
                    int OldBlue = Pixels[CurrentLine + x];
                    int OldGreen = Pixels[CurrentLine + x + 1];
                    int OldRed = Pixels[CurrentLine + x + 2];
                    pixelColor = Color.FromArgb(255, OldRed, OldGreen, OldBlue);


                    if (colors.Contains(pixelColor))
                    {
                        
                    }
                    else
                    {
                        colors.Add(pixelColor);
                    }


                    pixelColor = Color.Empty;

                }

            }
         
            result = colors.Count;
            picture.UnlockBits(bitmapData);
           // MessageBox.Show(string.Format("Colors: {0}", result.ToString()));
            return result;




            //int bytesPerPixel = 3;

            //int width = picture.Width;
            //int height = picture.Height;
            //for (int i = 0; i < width; i++)
            //{

            //    for (int j = 0; j < height; j++)
            //    {
            //        int bIndex = j * bytesPerPixel;
            //        int gIndex = bIndex + 1;
            //        int rIndex = bIndex + 2;

            //        byte pixelR = row[rIndex];
            //        byte pixelG = row[gIndex];
            //        byte pixelB = row[bIndex];

            //pixelColor = picture.GetPixel(i, j).Name;
            //if (colors.Count == 0)
            //{
            //    colors.Add(pixelColor);
            //}
            //foreach (var c in colors)
            //{

            //    if (colors.Contains(pixelColor))
            //    {
            //        checker = false;
            //    }
            //    else
            //    {
            //        checker = true;
            //    }
            //}
            //if (checker)
            //{
            //    colors.Add(pixelColor);
            //}
            //pixelColor = null;


            //    }
            //}



        }

        private void btn_CountColors_Click(object sender, EventArgs e)
        {
            int result = 0;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            result = CountColors();
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.


            // Format and display the TimeSpan value.
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //    ts.Hours, ts.Minutes, ts.Seconds,
            //    ts.Milliseconds / 10);


            //string path = @"psf\Home\Desktop\мельник.jpeg";

            MessageBox.Show(string.Format("Colors:{0} , Runtime: {1}", result, stopWatch.Elapsed));


        }
    }
}
