using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public class CollisionDetection
    {
        private GameObject attacker;
        private GameObject innocent;
        private PictureBox picBox1;
        private PictureBox picBox2;
        private ICollisionReaction collision;

        public CollisionDetection(GameObject attacker, GameObject innocent, ICollisionReaction collision)
        {
            this.attacker = attacker;
            this.innocent = innocent;
            this.picBox1 = attacker.getPicture();
            this.picBox2 = innocent.getPicture();
            this.collision = collision;
        }

        public void checkCollision()
        {
            if (picBox1.Bounds.IntersectsWith(picBox2.Bounds))
            {
                collision.RenderCollision(innocent);
            }
        }
    }
}
