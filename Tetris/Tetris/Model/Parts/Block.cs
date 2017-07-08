using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Tetris.Model
{
    public class Block
    {
        public Point Position { get; set; }

        private Color Color { get; }

        private ImageBrush ImageBrush { get; }

        public Block(double x, double y, Color color, ImageBrush imageBrush = null)
        {
            Position = new Point(x, y);
            Color = color;
            ImageBrush = imageBrush;
        }

        public void Draw(Canvas canvas)
        {
            var rect = new Rectangle
            {
                Width = 10,
                Height = 10,
                Fill = new SolidColorBrush(Color)
            };
            if (ImageBrush != null)
            {
                rect.Fill = ImageBrush;
            }
            rect.SetValue(Canvas.LeftProperty, Position.X*10);
            rect.SetValue(Canvas.TopProperty, Position.Y*10);
            canvas.Children.Add(rect);
        }
    }
}