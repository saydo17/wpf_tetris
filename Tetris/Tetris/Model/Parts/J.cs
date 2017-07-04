using System.Windows.Media;

namespace Tetris.Model
{
    internal class J : Part
    {
        public J()
        {
            Type = PartType.J;
            Size =  3;
            Matrix = new[,]
            {
                {0, 1, 0},
                {0, 1, 0},
                {1, 1, 0}
            };
            Color = Colors.Chartreuse;
        }
    }
}