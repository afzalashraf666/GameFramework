using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    class Game
    {
        private ArrayList objectsArrayList = new ArrayList();
        public void addGameObject(GameObject newObj)
        {
            objectsArrayList.Add(newObj);
        }

        public void Update()
        {
            for (int idx = 0; idx < objectsArrayList.Count; idx++)
            {
                GameObject newObj = (GameObject)objectsArrayList[idx];
                newObj.UpdatePosition();
            }
        }
    }
}