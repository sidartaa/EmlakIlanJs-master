using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace WebApiService.Models
{
    public static class ImagesProses
    {
        public static void ResimBoyutlandir(string resimad, int buyukGenislik, int kucukGenislik)
        {
            var resimBuyukYol = Path.Combine(HttpContext.Current.Server.MapPath("~/Userimage/"), resimad);
            var resim = new WebImage(resimBuyukYol);
            string filenameNoExtension = Path.GetFileNameWithoutExtension(resimBuyukYol);
            string extension = Path.GetExtension(resimBuyukYol);
            string filename = Path.GetFileName(resimBuyukYol);
            if (resim.Width > buyukGenislik)
            {
                resim.Resize(buyukGenislik, ((buyukGenislik * resim.Height) / resim.Width), preserveAspectRatio: true);
                //resim.Resize(kucukGenislik, ((kucukGenislik * resim.Width) / resim.Height), preserveAspectRatio: true);
            }
            //var resimKucukYol = Path.Combine(HttpContext.Current.Server.MapPath("~/Upload/slide-show/"), buyukGenislik + "-px-" + filenameNoExtension + extension);
            resim.AddTextWatermark("Torbalı Burada", "White",40, "Regular", "Arial", "Center", "Middle", 20, 5);
            resim.Save(resimBuyukYol);

            //return buyukGenislik + "-px-" + filenameNoExtension + extension;

        }
        
        public static void WatermarkImage(string sourceImage, string text, string targetImage, ImageFormat fmt,string resimYolu)
        {
            try

            {

                // open source image as stream and create a memorystream for output

                FileStream source = new FileStream(sourceImage, FileMode.Open);
                Stream output = new MemoryStream();

                Image img = Image.FromStream(source);



                // choose font for text

                Font font = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel);



                //choose color and transparency

                Color color = Color.FromArgb(100, 255, 0, 0);



                //location of the watermark text in the parent image

                Point pt = new Point(10, 5);

                SolidBrush brush = new SolidBrush(color);



                //draw text on image

                Graphics graphics = Graphics.FromImage(img);

                graphics.DrawString(text, font, brush, pt);

                graphics.Dispose();



                //update image memorystream

                img.Save(output, fmt);

                Image imgFinal = Image.FromStream(output);



                //write modified image to file

                Bitmap bmp = new System.Drawing.Bitmap(img.Width, img.Height, img.PixelFormat);

                Graphics graphics2 = Graphics.FromImage(bmp);

                graphics2.DrawImage(imgFinal, new Point(0, 0));

                bmp.Save(targetImage, fmt);
                imgFinal.Dispose();
                img.Dispose();
            }

            catch (Exception ex)
            {

                string ess = ex.Message;

            }
        }
    }
}