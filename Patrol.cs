using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    class Patrol : IMovement
    {
        int Top;
        int Left = 0;
        static int patrol;
        public IMovement Move()
        {
            if (patrol / 2 == 0)
            {
                Left = -13;
                patrol++;
                return new MoveRight();
            }

            else
            {
                Left = 13;
                patrol++;
                return new MoveLeft();
            }
        }

        public int TopDirection()
        {
            return Top;
        }

        public int LeftDirection()
        {
            return Left;
        }
    }
}
