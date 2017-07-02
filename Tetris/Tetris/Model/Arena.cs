namespace Tetris.Model
{
    public class Arena : ModelBase
    {
        private int _height;
        private int _width;
        private int[,] _matrix;

        public Arena(int height, int width)
        {
            Height = height;
            Width = width;
            Matrix = new int[width,height];
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int[,] Matrix
        {
            get { return _matrix; }
            set
            {
                if(_matrix == value) return;
                _matrix = value;
                OnPropertyChanged();
            }
        }
    }
}