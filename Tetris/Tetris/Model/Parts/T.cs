namespace Tetris.Model
{
    internal class T : Part
    {
        public T()
        {
            Type = PartType.T;
            Matrix = new[,]
{
                {0, 0, 0},
                {1, 1, 1},
                {0, 1, 0}
            };
        }
    }
}