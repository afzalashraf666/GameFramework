using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public class DecreaseHealth : ICollisionReaction
    {
        public void RenderCollision(GameObject innocent)
        {
            innocent.Disappear();
        }
    }
}
