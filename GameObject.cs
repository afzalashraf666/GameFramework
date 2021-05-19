using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    class GameObject
    {
        private int speed;
        PictureBox gameElement = new PictureBox();
        IMovement direction;

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
            this.gameElement.Top = this.gameElement.Top + speed * (direction.TopDirection() / 3);
            this.gameElement.Left = this.gameElement.Left + speed * (direction.LeftDirection() / 3);
        }
    }
}
