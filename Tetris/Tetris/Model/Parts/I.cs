using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Tetris.Model
{
    internal class I : Part
    {
        public I()
        {
            Type = PartType.I;
            Size = 4;
            Matrix = new[,]
            {
                {0, 1, 0, 0 },
                {0, 1, 0, 0 },
                {0, 1, 0, 0 },
                {0, 1, 0, 0 },
            };
            ImageBrush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Content/PurpleBlock.png")));
            Color = Colors.BlueViolet;
        }
    }
}