using System.Windows.Forms;

namespace GameFramework
{
    interface IMovement
    {
        void Move(PictureBox picture, int speed);
    }
}