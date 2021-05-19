using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    class MoveRight : IMovement
    {
        int Top = 0;
        int Left = 3;

        public IMovement Move()
        {
            return new MoveRight();
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
