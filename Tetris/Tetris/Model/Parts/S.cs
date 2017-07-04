using System.Windows.Media;

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
            Color = Colors.Blue;
        }
    }
}