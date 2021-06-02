using System.Windows.Forms;
namespace GameFramework
{
    public class MoveUp : IMovement
    {
        private Movement movementEnum = Movement.Up;
        public Movement getMovementEnum()
        {
            return movementEnum;
        }

        public void Move(PictureBox picture, int speed)
        {
            picture.Top -= speed;
        }
    }
}