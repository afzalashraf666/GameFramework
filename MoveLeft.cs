using System.Windows.Forms;
namespace GameFramework
{
    public class MoveLeft : IMovement
    {
        public void Move(PictureBox picture, int speed)
        {
            picture.Left -= speed;
        }
    }
}