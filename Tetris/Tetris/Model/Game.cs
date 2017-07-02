using System;
using System.Windows.Controls;

namespace Tetris.Model
{
    public class Game
    {
        private readonly Canvas _gameCanvas;
        private PartFactory _partFactory;
        private Player _player;

        public Game(Canvas gameCanvas)
        {
            _partFactory = new PartFactory();
            _gameCanvas = gameCanvas;
            _player = new Player(_partFactory);
        }

        public void Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}