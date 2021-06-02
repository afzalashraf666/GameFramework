using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public class MovementPool
    {
        private static MovementPool MovementPoolObject;

        private static ArrayList availableMovements = new ArrayList();

        private static ArrayList occupiedMovements = new ArrayList();

        private MovementPool()
        {

        }

        public static MovementPool getOnePool()
        {
            if (MovementPoolObject == null)
            {
                availableMovements.Add(new MoveLeft());
                availableMovements.Add(new MoveKeyBoard());
                availableMovements.Add(new MoveRight());
                MovementPoolObject = new MovementPool();
            }
            return MovementPoolObject;
        }

        public IMovement Acquire(Movement MovementType)
        {
            for (int idx = 0; idx < availableMovements.Count; idx++)
            {
                IMovement foundMovement = (IMovement)availableMovements[idx];
                if (foundMovement.getMovementEnum() == MovementType)
                {
                    availableMovements.Remove(foundMovement);
                    occupiedMovements.Add(foundMovement);
                    return foundMovement;
                }
            }

            if (MovementType == Movement.Left)
            {
                IMovement newMovement = new MoveLeft();
                availableMovements.Add(newMovement);
                return newMovement;
            }

            else if (MovementType == Movement.Right)
            {
                IMovement newMovement = new MoveRight();
                availableMovements.Add(newMovement);
                return newMovement;
            }
            return new MoveKeyBoard();
        }

        public void Release(IMovement MovementType)
        {
            for (int idx = 0; idx < occupiedMovements.Count; idx++)
            {
                IMovement foundMovement = (IMovement)occupiedMovements[idx];
                if (foundMovement == MovementType)
                {
                    availableMovements.Add(foundMovement);
                    occupiedMovements.Remove(foundMovement);
                }
            }
        }
    }
}