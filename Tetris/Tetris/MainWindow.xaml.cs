using System.Windows;
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
            DispatcherTimer gameTimer = new DispatcherTimer(DispatcherPriority.Render);
            gameTimer.Tick += _game.Tick;
        }
    }
}