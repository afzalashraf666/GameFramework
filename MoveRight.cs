using System.Windows.Forms;
namespace GameFramework
{
    public class MoveRight : IMovement
    {
        public void Move(PictureBox picture, int speed)
        {
            picture.Left += speed;
        }
    }
}
