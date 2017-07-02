using System;
using System.ComponentModel;

namespace Tetris.Model
{
    public class Player : ModelBase
    {
        private readonly PartFactory _partFactory;
       
        private int _score;
        private Part _part;

        public Player(PartFactory partFactory)
        {
            _partFactory = partFactory;
            Score = 0;
            Part = _partFactory.RandomPart();
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
                if(_part == value)
                _part = value;
                OnPropertyChanged();
            }
        }
    }
}