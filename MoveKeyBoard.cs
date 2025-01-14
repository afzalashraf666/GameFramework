﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GameFramework
{
    public class MoveKeyBoard : IMovement
    {
        private Movement movementEnum = Movement.Left;
        static bool moveLeft, moveRight;

        public Movement getMovementEnum()
        {
            return movementEnum;
        }

        public void Move(PictureBox picture, int speed)
        {
            if (moveLeft)
            {
                picture.Left -= speed;
            }

            else if (moveRight)
            {
                picture.Left += speed;
            }
        }

        public void KeyDown(MMentKeys pressedKey)
        {
            if (pressedKey == MMentKeys.Left)
            {
                moveLeft = true;
            }

            else if (pressedKey == MMentKeys.Right)
            {
                moveRight = true;
            }
        }

        public void KeyUp(MMentKeys unPressedKey)
        {
            if (unPressedKey == MMentKeys.Left)
            {
                moveLeft = false;
            }

            else if (unPressedKey == MMentKeys.Right)
            {
                moveRight = false;
            }
        }
    }
}