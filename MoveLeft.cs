using System.Windows.Forms;
namespace GameFramework
{
    class MoveLeft : IMovement
    {
        public void Move(PictureBox picture, int speed)
        {
            picture.Left -= speed;
        }
    }
}