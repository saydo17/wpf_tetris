using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Tetris.Model
{
    internal class S : Part
    {
        public S()
        {
            Type = PartType.S;
            Size = 3;
            Matrix = new[,]
            {
                {0, 0, 0},
                {0, 1, 1},
                {1, 1, 0}
            };
            ImageBrush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Content/BlueBlock.png")));
            Color = Colors.Blue;
        }
    }
}