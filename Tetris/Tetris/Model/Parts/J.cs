namespace Tetris.Model
{
    internal class J : Part
    {
        public J()
        {
            Type = PartType.J;
            Matrix = new[,]
{
                {0, 1, 0},
                {0, 1, 0},
                {1, 1, 0}
            };
        }
    }
}