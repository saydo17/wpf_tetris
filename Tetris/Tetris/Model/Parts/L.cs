using System.Windows.Media;

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
            Color = Colors.Gold;
        }
    }
}