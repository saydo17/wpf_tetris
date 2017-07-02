namespace Tetris.Model
{
    internal class S : Part
    {
        public S()
        {
            Type = PartType.S;
            Matrix = new[,]
{
                {0, 0, 0},
                {0, 1, 1},
                {1, 1, 0}
            };
        }
    }
}