using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Tetris.Model
{
    internal class J : Part
    {
        public J()
        {
            Type = PartType.J;
            Size =  3;
            Matrix = new[,]
            {
                {0, 1, 0},
                {0, 1, 0},
                {1, 1, 0}
            };
            ImageBrush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Content/GreenBlock.png")));
            Color = Colors.Chartreuse;
        }
    }
}