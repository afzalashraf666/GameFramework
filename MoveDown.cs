using System.Windows.Forms;
namespace GameFramework
{
    public class MoveDown : IMovement
    {
        private Movement movementEnum = Movement.Down;
        public Movement getMovementEnum()
        {
            return movementEnum;
        }

        public void Move(PictureBox picture, int speed)
        {
            picture.Top += speed;
        }
    }
}
