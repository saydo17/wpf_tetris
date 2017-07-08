using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Tetris.Model
{
    internal class O : Part
    {
        public O()
        {
            Type = PartType.O;
            Size = 2;
            Matrix = new[,]
            {
                {1, 1},
                {1, 1},
            };
            ImageBrush = new ImageBrush(new BitmapImage(new Uri("pack://application:,,,/Content/RedBlock.png")));
            Color = Colors.Red;
        }
    }
}