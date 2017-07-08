using System;
using System.ComponentModel;
using System.Resources;
using System.Windows;
using System.Windows.Controls;

namespace Tetris.Model
{
    public class Player : ModelBase, IDrawable
    {
        private readonly PartFactory _partFactory;
       
        private int _score;
        private Part _part;
        private readonly Arena _arena;

        public int LinesCleared
        {
            get { return _linesCleared; }
            set
            {
                if(_linesCleared == value) return;
                _linesCleared = value;
                OnPropertyChanged();
            }
        }

        public Player(PartFactory partFactory, Arena arena)
        {
            _arena = arena;
            _linesCleared = 0;
            _partFactory = partFactory;
            Score = 0;
            Reset();
            
        }

        public bool IsAlive { get; set; }
        public EventHandler Died;
        private int _linesCleared;

        private void Reset()
        {
            IsAlive = true;
            Part = _partFactory.RandomPart();
            Part.PositionX = _arena.Width / 2 -Part.Size/2;
            Part.PositionY = -Part.Size + 1;
            if (_arena.CheckCollision(Part))
            {
                IsAlive = false;
                Part.PositionY--;
                Died?.Invoke(this, EventArgs.Empty);
            }
        }


        public int Score
        {
            get { return _score; }
            set
            {
                if(_score == value) return;
                _score = value;
                OnPropertyChanged();
                
            }
        }

        public Part Part
        {
            get { return _part; }
            set
            {
                if(_part == value) return;
                _part = value;
                OnPropertyChanged();
            }
        }


        public void Draw(Canvas canvas)
        {
            _part.Draw(canvas);
        }

        public void MoveDown()
        {
            _part.PositionY += 1;
            if (_arena.CheckCollision(Part))
            {
                _part.PositionY -= 1;
                _arena.Merge(Part);
                Reset();
            }
        }

        public void MoveLeft()
        {
            _part.PositionX -= 1;
            if (_arena.CheckCollision(Part))
                _part.PositionX += 1;
        }

        public void MoveRight()
        {
            _part.PositionX += 1;
            if (_arena.CheckCollision(Part))
                _part.PositionX -= 1;
        }

        public void Rotate()
        {
            _part.Rotate();
            var originalPosition = _part.PositionX;
            var offset = 1;

            while (_arena.CheckCollision(_part))
            {
                _part.PositionX += offset;
                offset = -(offset + (offset > 0 ? 1 : -1));
                if (offset > _part.Size)
                {
                    _part.Rotate();
                    _part.Rotate();
                    _part.Rotate();
                    _part.PositionX = originalPosition;
                }
            }
        }
    }
}