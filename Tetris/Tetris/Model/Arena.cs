using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Tetris.Model
{
    public class Arena : ModelBase, IDrawable
    {
        private List<Block> _blocks;

        public Arena(int height, int width)
        {
            Height = height;
            Width = width;
            _blocks = new List<Block>();
        }


        public int Width { get; }

        public int Height { get; }

        public void Draw(Canvas canvas)
        {
            foreach (var block in _blocks)
            {
                block.Draw(canvas);
            }
        }

        public bool CheckCollision(Part part)
        {
            foreach (var block in part.Blocks)
            {
                if (block.Position.Y >= Height)
                    return true;
                if (block.Position.X >= Width)
                    return true;
                if (block.Position.X < 0) return true;
            }

            return (from block in _blocks
                    let partBlockPoints = part.Blocks.Select(b => b.Position)
                    where partBlockPoints.Contains(block.Position)
                    select block).Any();
        }

        public void Merge(Part part)
        {
            foreach (var block in part.Blocks)
            {
                _blocks.Add(block);
            }
        }

        public int Sweep()
        {
            var rowCount = 0;
            for (int i = Height-1; i > 0; i--)
            {
                if (_blocks.Count(b => b.Position.Y == i) == Width)
                {
                    _blocks.RemoveAll(b => b.Position.Y == i);
                    ShiftBlocksDown(i);
                    i++;
                    rowCount++;
                }

            }
            return rowCount;
        }

        private void ShiftBlocksDown(int y)
        {
            foreach (var block in _blocks)
            {
                if (block.Position.Y < y)
                    block.Position = new Point(block.Position.X, block.Position.Y + 1);
            }
        }
    }
}