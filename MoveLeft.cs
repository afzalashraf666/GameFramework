using System.Windows.Forms;
namespace GameFramework
{
    public class MoveLeft : IMovement
    {
        private Movement movementEnum = Movement.Left;
        public Movement getMovementEnum()
        {
            return movementEnum;
        }

        public void Move(PictureBox picture, int speed)
        {
            picture.Left -= speed;
        }
    }
}