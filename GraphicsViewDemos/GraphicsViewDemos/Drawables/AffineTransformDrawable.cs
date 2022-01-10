using Microsoft.Maui.Graphics;
using System;

namespace GraphicsViewDemos.Drawables
{
    internal class AffineTransformDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectangleF dirtyRect)
        {
            PathF path = new PathF();
            for (int i = 0; i < 11; i++)
            {
                double angle = 5 * i * 2 * Math.PI / 11;
                PointF point = new PointF(100 * (float)Math.Sin(angle), -100 * (float)Math.Cos(angle));

                if (i == 0)
                    path.MoveTo(point);
                else
                    path.LineTo(point);
            }


            AffineTransform transform = new AffineTransform(1.5f, 1, 0, 1, 150, 150);
            canvas.ConcatenateTransform(transform);
            canvas.FillColor = Colors.Red;
            canvas.FillPath(path);
        }
    }
}
