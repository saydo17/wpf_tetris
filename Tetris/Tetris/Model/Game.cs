using System;
using System.Resources;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace Tetris.Model
{
    public class Game : ModelBase
    {
        private Canvas _gameCanvas;
        private PartFactory _partFactory;
        private Player _player;
        private Arena _arena;
        private DispatcherTimer timer;
        private bool _isPaused;

        public Game(Canvas gameCanvas)
        {
            _gameCanvas = gameCanvas;
            _partFactory = new PartFactory();
            Reset();

            timer = new DispatcherTimer(DispatcherPriority.Render);
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += Tick;
            timer.Start();
        }

        private void Reset()
        {
            _arena = new Arena(20, 10);
            _player = new Player(_partFactory, _arena);
            _player.Died += OnPlayerDied;
        }

        private void OnPlayerDied(object sender, EventArgs e)
        {
            timer.Stop();
            //_player.Died -= OnPlayerDied;
        }

        public Player Player
        {
            get { return _player; }
            set
            {
                if(_player == value) return;
                _player = value;
                OnPropertyChanged();
            }
        }


        private void Tick(object sender, EventArgs e)
        {
            DropAndSweep();
            Draw();
        }

        private void DropAndSweep()
        {
            _player.MoveDown();
            _player.Score += _arena.Sweep();
        }

        private void Pause()
        {
            _isPaused = true;
            timer.Stop();
        }

        private void Resuem()
        {
            _isPaused = false;
            timer.Start();
        }

        private void Draw()
        {
            _gameCanvas.Children.Clear();
            _arena.Draw(_gameCanvas);
            _player.Draw(_gameCanvas);
        }

        public void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (!_isPaused && _player.IsAlive)
            {
                if (e.Key == Key.W)
                    _player.Rotate();
                if (e.Key == Key.A)
                    _player.MoveLeft();
                if (e.Key == Key.D)
                    _player.MoveRight();
                if (e.Key == Key.S)
                {
                    DropAndSweep();
                    timer.Stop();
                    timer.Start();
                }
            }
            else if(_isPaused)
            {
                if(e.Key == Key.Escape && _isPaused)
                    Resuem();
                else if (e.Key == Key.Escape && !_isPaused)
                    Pause();    
            }
            else if (!_player.IsAlive)
            {
                if (e.Key == Key.Space)
                    Reset();
            }


            Draw();
        }
    }
}