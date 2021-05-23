using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    class MovementFactory
    {
        public IMovement getMovement(Movement MovementType)
        {
            if (MovementType == Movement.Left)
            {
                return new MoveLeft();
            }

            else if (MovementType == Movement.Right)
            {
                return new MoveRight();
            }

            else if (MovementType == Movement.Keyboard)
            {
                return new MoveKeyBoard();
            }

            else if (MovementType == Movement.Left)
            {
                return new Patrol();
            }
            return new MoveKeyBoard();
        }
    }
}