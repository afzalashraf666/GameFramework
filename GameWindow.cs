using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFramework
{
    public partial class GameWindow : Form
    {
        Game g = new Game();
        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            GameObject newobj = new GameObject(picBox, 1);
            g.addGameObject(newobj);
            GameObject newobj2 = new GameObject(picBox2, 2);
            g.addGameObject(newobj2);
            GameObject newobj3 = new GameObject(picBox3, 3);
            g.addGameObject(newobj3);
            GameObject newobj4 = new GameObject(picBox4, 3);
            g.addGameObject(newobj4);
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            ArrayList tempList = new ArrayList();
            tempList = g.returnObjects();

            for (int idx = 0; idx < tempList.Count; idx++)
            {
                GameObject newObj = (GameObject)tempList[idx];
                newObj.UpdatePosition();
            }
        }
    }
}
