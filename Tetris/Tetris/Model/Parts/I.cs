using System.Windows.Media;

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
            Color = Colors.BlueViolet;
        }
    }
}