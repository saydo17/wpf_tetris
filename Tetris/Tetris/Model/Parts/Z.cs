using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Tetris.Model
{
    internal class Z : Part
    {
        public Z()
        {
            Type = PartType.Z;
            Size = 3;
            Matrix = new[,]
            {
                {0, 0, 0},
                {1, 1, 0},
                {0, 1, 1}
            };
            ImageBrush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Content/DarkGreenBlock.png")));
            Color = Colors.Green;
        }
    }
}