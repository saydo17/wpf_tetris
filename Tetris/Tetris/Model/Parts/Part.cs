using System.Windows;

namespace Tetris.Model
{
    public class Part
    {
        public PartType Type { get; set; }

        public int[,] Matrix { get; set; }

        public Point Position { get; set; }
    }
}