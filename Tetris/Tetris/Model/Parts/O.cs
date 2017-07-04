using System.Windows.Media;

namespace Tetris.Model
{
    internal class O : Part
    {
        public O()
        {
            Type = PartType.O;
            Size = 2;
            Matrix = new[,]
            {
                {1, 1},
                {1, 1},
            };

            Color = Colors.Red;
        }
    }
}