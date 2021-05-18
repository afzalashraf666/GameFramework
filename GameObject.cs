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

        public GameObject(PictureBox gameElement, int speed)
        {
            this.speed = speed;
            this.gameElement = gameElement;

        }

        public void UpdatePosition()
        {
            this.gameElement.Left -= 5;
        }
    }
}
