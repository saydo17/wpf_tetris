using System.Windows.Media;

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
            Color = Colors.Green;
        }
    }
}