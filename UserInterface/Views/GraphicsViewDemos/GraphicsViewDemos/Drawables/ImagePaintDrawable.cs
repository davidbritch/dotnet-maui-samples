using Microsoft.Maui.Graphics;
using System.Reflection;

namespace GraphicsViewDemos.Drawables
{
    internal class ImagePaintDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            IImage image;
            var assembly = GetType().GetTypeInfo().Assembly;
            using (var stream = assembly.GetManifestResourceStream("GraphicsViewDemos.Resources.Images.dotnet_bot.png"))
            {
                image = GraphicsPlatform.CurrentService.LoadImageFromStream(stream);
            }

            //if (image != null)
            //{
            //    ImagePaint imagePaint = new ImagePaint
            //    {
            //        Image = image.Downsize(100)
            //    };
            //    canvas.SetFillPaint(imagePaint, RectangleF.Zero);
            //    canvas.FillRectangle(0, 0, 240, 300);
            //}

            if (image != null)
            {
                canvas.SetFillImage(image.Downsize(100));
                canvas.FillRectangle(0, 0, 240, 300);
            }
        }
    }
}
