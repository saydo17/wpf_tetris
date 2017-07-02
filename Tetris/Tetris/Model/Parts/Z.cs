namespace Tetris.Model
{
    internal class Z : Part
    {
        public Z()
        {
            Type = PartType.Z;
            Matrix = new[,]
{
                {0, 0, 0},
                {1, 1, 0},
                {0, 1, 1}
            };
        }
    }
}