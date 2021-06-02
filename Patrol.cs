using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GameFramework
{
    public class Patrol : IMovement
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
