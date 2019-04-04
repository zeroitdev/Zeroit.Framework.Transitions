// ***********************************************************************
// Assembly         : Zeroit.Framework.Transitions
// Author           : ZEROIT
// Created          : 12-02-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="ImageExtensions.cs" company="Zeroit Dev Technologies">
//    This program is for creating components to aid in Animating controls.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
#region Imports

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
//using System.Windows.Forms.VisualStyles;

#endregion

namespace Zeroit.Framework.Transitions
{
    #region ImageExtensions
    /// <summary>
    /// Class ImageExtensions.
    /// </summary>
    public static class ImageExtensions
    {
        /// <summary>
        /// Determines whether the specified threshold is blank.
        /// </summary>
        /// <param name="img">The img.</param>
        /// <param name="threshold">The threshold.</param>
        /// <param name="checkOnePixelEveryN">The check one pixel every n.</param>
        /// <returns><c>true</c> if the specified threshold is blank; otherwise, <c>false</c>.</returns>
        /// <exception cref="ArgumentException">Must check at least one pixel every 1 pixel (every pixel)</exception>
        public static bool IsBlank(this Image img, int threshold, int checkOnePixelEveryN = 1)
        {
            if (checkOnePixelEveryN <= 0)
                throw new ArgumentException("Must check at least one pixel every 1 pixel (every pixel)");

            return img.GetStandardDeviation() < threshold;
        }

        /// <summary>
        /// Get the standard deviation of pixel values.
        /// </summary>
        /// <param name="img">The img.</param>
        /// <param name="checkOnePixelEveryN">The check one pixel every n.</param>
        /// <returns>Standard deviation.</returns>
        /// <exception cref="ArgumentException">Must check at least one pixel every 1 pixel (every pixel)</exception>
        private static double GetStandardDeviation(this Image img, int checkOnePixelEveryN = 1)
        {
            if (checkOnePixelEveryN <= 0)
                throw new ArgumentException("Must check at least one pixel every 1 pixel (every pixel)");

            double total = 0, totalVariance = 0;
            int count = 1;
            double stdDev = 0;

            // First get all the bytes
            using (Bitmap bmp = new Bitmap(img))
            {
                BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, bmp.PixelFormat);
                int stride = bmData.Stride;
                IntPtr Scan0 = bmData.Scan0;
                unsafe
                {
                    byte* pointer = (byte*)Scan0;
                    int nOffset = stride - bmp.Width * 3;

                    for (int y = 0; y < bmp.Height; pointer += nOffset, y += checkOnePixelEveryN)
                    {
                        for (int x = 0; x < bmp.Width; count++, pointer += 3, x += checkOnePixelEveryN)
                        {
                            byte blue = pointer[0];
                            byte green = pointer[1];
                            byte red = pointer[2];

                            int pixelValue = Color.FromArgb(0, red, green, blue).ToArgb();
                            total += pixelValue;

                            double avg = total / count;
                            totalVariance += Math.Pow(pixelValue - avg, 2);
                            stdDev = Math.Sqrt(totalVariance / count);
                        }
                    }
                }

                bmp.UnlockBits(bmData);
            }

            return stdDev;
        }

        /// <summary>
        /// Resize an image by a percentage factor
        /// </summary>
        /// <param name="image">Source image</param>
        /// <param name="percent">The percent.</param>
        /// <returns>Scaled image</returns>
        public static Image ScaleByPercentage(this Image image, int percent)
        {
            float nPercent = ((float)percent / 100);

            int destWidth = (int)(image.Width - (image.Width * nPercent));
            int destHeight = (int)(image.Height - (image.Height * nPercent));

            Bitmap bmp = new Bitmap(destWidth, destHeight, PixelFormat.Format24bppRgb);
            bmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                var destRect = new Rectangle(0, 0, destWidth, destHeight);
                var srcRect = new Rectangle(0, 0, image.Width, image.Height);

                graphics.DrawImage(image, destRect, srcRect, GraphicsUnit.Pixel);
            }

            return bmp;
        }

        /// <summary>
        /// Resizes the specified new size.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="newSize">The new size.</param>
        /// <returns>Image.</returns>
        public static Image Resize(this Image image, System.Drawing.Size newSize)
        {
            Bitmap bmp = new Bitmap(newSize.Width, newSize.Height);
            using (var gx = Graphics.FromImage((Image)bmp))
            {
                gx.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gx.DrawImage(image, 0, 0, newSize.Width, newSize.Height);
            }

            return (Image)bmp;
        }

        /// <summary>
        /// To the grayscale.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <returns>Image.</returns>
        public static Image ToGrayscale(this Image source)
        {
            var bmp = new Bitmap(source.Width, source.Height);

            using (var graphics = Graphics.FromImage(bmp))
            {
                var colorMatrix = new ColorMatrix
                (
                    new float[][]
                    {
                        new float[] { 0.5f, 0.5f, 0.5f, 0, 0 },
                        new float[] { 0.5f, 0.5f, 0.5f, 0, 0 },
                        new float[] { 0.5f, 0.5f, 0.5f, 0, 0 },
                        new float[] { 0, 0, 0, 1, 0, 0 },
                        new float[] { 0, 0, 0, 0, 1, 0 },
                        new float[] { 0, 0, 0, 0, 0, 1 }
                    }
                );

                var imageAttrs = new ImageAttributes();
                imageAttrs.SetColorMatrix(colorMatrix, ColorMatrixFlag.SkipGrays);

                var destRect = new Rectangle(0, 0, source.Width, source.Height);
                graphics.DrawImage(source, destRect, 0, 0, source.Width, source.Height, GraphicsUnit.Pixel, imageAttrs);
            }

            return bmp;
        }

        /// <summary>
        /// Changes the opacity.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="opacity">A value between 0 (full transparency) and 100 (full opacity)</param>
        /// <returns>Image.</returns>
        public static Image ChangeOpacity(this Image image, int opacity)
        {
            opacity = opacity < 0 ? 0 : opacity;
            opacity = opacity > 100 ? 100 : opacity;

            //create a Bitmap the size of the image provided  
            Bitmap bmp = new Bitmap(image.Width, image.Height);

            //create a graphics object from the image  
            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                //create a color matrix object  
                ColorMatrix matrix = new ColorMatrix();

                //set the opacity  
                matrix.Matrix33 = ((float)opacity) / 100;

                //create image attributes  
                ImageAttributes attributes = new ImageAttributes();

                //set the color (opacity) of the image  
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                //now draw the image  
                gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }

            return bmp;
        }

        /// <summary>
        /// To the black white.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="threshold">The threshold.</param>
        /// <returns>Image.</returns>
        public static Image ToBlackWhite(this Image image, float threshold = 0.7f)
        {
            var outImage = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb);
            using (Graphics gr = Graphics.FromImage(outImage))
            {
                var grayMatrix = new ColorMatrix(new float[][]
                {
                    new float[] { 0.299f, 0.299f, 0.299f, 0, 0 },
                    new float[] { 0.587f, 0.587f, 0.587f, 0, 0 },
                    new float[] { 0.114f, 0.114f, 0.114f, 0, 0 },
                    new float[] { 0,      0,      0,      1, 0 },
                    new float[] { 0,      0,      0,      0, 1 }
                });

                var ia = new ImageAttributes();
                ia.SetColorMatrix(grayMatrix);
                ia.SetThreshold(threshold);

                var rc = new Rectangle(0, 0, image.Width, image.Height);
                gr.DrawImage(image, rc, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, ia);

                return outImage;
            }
        }

        /// <summary>
        /// To the stream.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="format">The format.</param>
        /// <returns>MemoryStream.</returns>
        public static MemoryStream ToStream(this Image image, ImageFormat format)
        {
            var stream = new MemoryStream();
            image.Save(stream, format);
            stream.Position = 0;

            return stream;
        }

        /// <summary>
        /// Equalses the specified BMP2.
        /// </summary>
        /// <param name="bmp1">The BMP1.</param>
        /// <param name="bmp2">The BMP2.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Equals(this Bitmap bmp1, Bitmap bmp2)
        {
            Rectangle rect = new Rectangle(0, 0, bmp1.Width, bmp1.Height);
            BitmapData bmpData1 = bmp1.LockBits(rect, ImageLockMode.ReadOnly, bmp1.PixelFormat);
            BitmapData bmpData2 = bmp2.LockBits(rect, ImageLockMode.ReadOnly, bmp2.PixelFormat);

            try
            {
                unsafe
                {
                    byte* ptr1 = (byte*)bmpData1.Scan0.ToPointer();
                    byte* ptr2 = (byte*)bmpData2.Scan0.ToPointer();
                    int width = rect.Width * 3; // for 24bpp pixel data

                    for (int y = 0; y < rect.Height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            if (*ptr1 != *ptr2)
                                return false;

                            ptr1++;
                            ptr2++;
                        }
                        ptr1 += bmpData1.Stride - width;
                        ptr2 += bmpData2.Stride - width;
                    }
                }
            }
            finally
            {
                bmp1.UnlockBits(bmpData1);
                bmp2.UnlockBits(bmpData2);
            }

            return true;
        }
    }
    #endregion
}
