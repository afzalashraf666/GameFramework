using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GameFramework
{
    public class GameFactory
    {
        private static GameFactory GameFactoryManager = null;
        MovementFactory MovemenetObj = MovementFactory.GetOneMovementFactory();
        static ArrayList GameObjectsCounter = new ArrayList();

        private GameFactory()
        {

        }

        public static GameFactory GetOneGameFactory()
        {
            if (GameFactoryManager == null)
            {
                GameFactoryManager = new GameFactory();
            }
            return GameFactoryManager;
        }

        public GameObject CreateGameObject(PictureBox picElement, int speed, Movement movementType, ObjectsType type)
        {
            IMovement movementObject = MovemenetObj.getMovement(movementType);
            GameObject GameObj = new GameObject(picElement, speed, movementObject, type);
            GameObjectsCounter.Add(type);
            return GameObj;
        }

        public GameObject CreateGameObject(PictureBox picElement, int speed, ObjectsType type)
        {
            GameObject GameObj = new GameObject(picElement, speed, type);
            GameObjectsCounter.Add(type);
            return GameObj;
        }
    }
}