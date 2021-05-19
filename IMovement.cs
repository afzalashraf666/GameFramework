using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    interface IMovement
    {
        IMovement Move();
        int TopDirection();
        int LeftDirection();
    }
}
