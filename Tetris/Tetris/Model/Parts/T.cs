using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Tetris.Model
{
    internal class T : Part
    {
        public T()
        {
            Type = PartType.T;
            Size = 3;
            Matrix = new[,]
            {
                {0, 0, 0},
                {1, 1, 1},
                {0, 1, 0}
            };
            ImageBrush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Content/CyanBlock.png")));
            Color = Colors.Aqua;
        }
    }
}