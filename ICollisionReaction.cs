using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public interface ICollisionReaction
    {
        void RenderCollision(GameObject innocent);
    }
}