namespace Tetris.Model
{
    internal class I : Part
    {
        public I()
        {
            Type = PartType.I;
            Matrix = new[,]
            {
                {0, 1, 0, 0 },
                {0, 1, 0, 0 },
                {0, 1, 0, 0 },
                {0, 1, 0, 0 },
            };
        }
    }
}