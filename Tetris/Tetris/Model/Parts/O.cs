namespace Tetris.Model
{
    internal class O : Part
    {
        public O()
        {
            Type = PartType.O;
            Matrix = new[,]
{
                {1, 1},
                {1, 1},
            };
        }
    }
}