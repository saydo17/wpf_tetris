using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Tetris.Model
{
    internal class L : Part
    {
        public L()
        {
            Type = PartType.L;
            Size = 3;
            Matrix = new[,]
            {
                {0, 1, 0},
                {0, 1, 0},
                {0, 1, 1}
            };
            ImageBrush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Content/YellowBlock.png")));
            Color = Colors.Gold;
        }
    }
}