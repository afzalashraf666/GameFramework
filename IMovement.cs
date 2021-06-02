using System.Windows.Forms;

namespace GameFramework
{
    public interface IMovement
    {
        void Move(PictureBox picture, int speed);
        Movement getMovementEnum();
    }
}