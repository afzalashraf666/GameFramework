using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    class MoveLeft : IMovement
    {
        public void Move(PictureBox picture, int speed)
        {
            picture.Left -= speed;
        }
    }
}