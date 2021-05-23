using System.Drawing;
using System.Windows.Forms;

namespace GameFramework
{
    class GameObject
    {
        private int speed;
        PictureBox gameElement = new PictureBox();
        public IMovement direction;

        public GameObject(PictureBox gameElement, int speed, IMovement direction)
        {
            this.speed = speed;
            this.gameElement = gameElement;
            this.gameElement.BackColor = Color.Transparent;
            this.direction = direction;
        }

        public GameObject(PictureBox gameElement, int speed)
        {
            this.speed = speed;
            this.gameElement = gameElement;
            this.gameElement.BackColor = Color.Transparent;
            this.direction = new MoveLeft();
        }

        public void UpdatePosition()
        {
            this.direction.Move(this.gameElement, this.speed);
        }
    }
}
