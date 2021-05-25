using System.Windows.Forms;
namespace GameFramework
{
    class MoveRight : IMovement
    {
        public void Move(PictureBox picture, int speed)
        {
            picture.Left += speed;
        }
    }
}
