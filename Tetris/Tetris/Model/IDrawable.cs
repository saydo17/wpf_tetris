using System.Security.Cryptography.X509Certificates;
using System.Windows.Controls;

namespace Tetris.Model
{
    public interface IDrawable
    {
        void Draw(Canvas _canvas);
    }
}