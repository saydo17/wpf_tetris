namespace Tetris.Model
{
    internal class L : Part
    {
        public L()
        {
            Type = PartType.L;
            Matrix = new[,]
            {
                {0, 1, 0},
                {0, 1, 0},
                {0, 1, 1}
            };
        }
    }
}