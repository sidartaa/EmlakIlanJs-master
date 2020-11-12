using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;

namespace TorbaliBurada.Controller
{
    public static class PhotoFileHelper
    {
        public static Image Resize(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }


        public static ImageFormat GetImageFormat(string extension)
        {
            switch (extension)
            {
                case ".png": return ImageFormat.Png;
                case ".jpg": return ImageFormat.Jpeg;
                case ".gif": return ImageFormat.Gif;
                default: return ImageFormat.Png;
            }
        }

        public static MediaTypeHeaderValue GetMediaContentType(string extension)
        {
            switch (extension)
            {
                case ".png": return new MediaTypeHeaderValue("image/png");
                case ".jpg": return new MediaTypeHeaderValue("image/jpeg");
                case ".gif": return new MediaTypeHeaderValue("image/gif");
                default: return new MediaTypeHeaderValue("image/png");
            }
        }

        public static Image Minify(Image resizedImage, string extension)
        {
            ImageCodecInfo imageCodec = GetImageCodec(extension);

            if (imageCodec == null) return resizedImage;

            Encoder encoder = Encoder.Quality;

            var encoderParameters = new EncoderParameters(1);

            var encoderParameter = new EncoderParameter(encoder, 100);

            encoderParameters.Param[0] = encoderParameter;

            var ms = new MemoryStream();

            resizedImage.Save(ms, imageCodec, encoderParameters);

            resizedImage = Image.FromStream(ms);

            return resizedImage;
        }

        private static ImageCodecInfo GetImageCodec(string extension)
        {
            ImageCodecInfo imageCodec = null;

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            switch (extension)
            {
                case ".png":
                    imageCodec = codecs.FirstOrDefault(x => x.FormatID == ImageFormat.Png.Guid);
                    break;

                case ".jpg":
                    imageCodec = codecs.FirstOrDefault(x => x.FormatID == ImageFormat.Jpeg.Guid);
                    break;

                case ".gif":
                    imageCodec = codecs.FirstOrDefault(x => x.FormatID == ImageFormat.Gif.Guid);
                    break;
            }

            return imageCodec;
        }
    }
}
