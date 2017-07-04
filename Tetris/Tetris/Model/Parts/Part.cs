using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tetris.Model
{
    public class Part : IDrawable
    {
        protected PartType Type { get; set; }

        protected int[,] Matrix { get; set; }

        public int Size { get; set; }

        public int PositionX { get; set; }

        public int PositionY { get; set; }

        protected Color Color { get; set; }

        public IEnumerable<Block> Blocks
        {
            get
            {
                var list = new List<Block>();
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        if (Matrix[i, j] == 1)
                        {
                            list.Add(new Block(PositionX + j, PositionY + i, Color));
                        }
                    }
                }
                return list;
            }
        }

        public void Draw(Canvas canvas)
        {
            foreach (var block in Blocks)
            {
                block.Draw(canvas);
            }
        }

        public void Rotate()
        {
            RotateMatrixInplace(Matrix);
        }

        private void RotateMatrixInplace(int[,] matrix)
        {
            var length = Size - 1;

            for (var i = 0; i <= (length) / 2; i++)
            {
                for (var j = i; j < length - i; j++)
                {

                    var temp = matrix[i,j];

                    matrix[i,j] = matrix[length - j,i];
                    matrix[length - j,i] = matrix[length - i,length - j];
                    matrix[length - i,length - j] = matrix[j,length - i];
                    matrix[j,length - i] = temp;
                }
            }
        }
    }
}