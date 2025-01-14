﻿using System.Windows.Forms;
namespace GameFramework
{
    public class MoveRight : IMovement
    {

        private Movement movementEnum = Movement.Right;
        public Movement getMovementEnum()
        {
            return movementEnum;
        }

        public void Move(PictureBox picture, int speed)
        {
            picture.Left += speed;
        }
    }
}
