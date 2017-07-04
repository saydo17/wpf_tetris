using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Tetris.Model;
using Tetris.ViewModel;

namespace Tetris
{
    public partial class MainWindow : Window
    {
        private Game _game;

        public MainWindow()
        {
            InitializeComponent();
            _game = new Game(GameCanvas);
            DataContext = this;

        }

        public Game Game
        {
            get { return _game; }
        }

        private void MainWindow_OnKeyDown(object sender, KeyEventArgs e)
        {
            _game.OnKeyDown(sender, e);
        }
    }
}