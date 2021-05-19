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
        Game game = Game.getInstance();
        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            picBox4.Hide();
            GameObject newobj = new GameObject(picBox, 1, new MoveLeft()); //left movement
            GameObject newobj2 = new GameObject(picBox2, 1, new MoveRight()); //right movement
            GameObject newobj3 = new GameObject(picBox3, 3); //default left movement,if movement not specified
            //GameObject newobj4 = new GameObject(picBox4, 3);
            game.addGameObject(newobj);
            game.addGameObject(newobj2);
            game.addGameObject(newobj3);
            //game.addGameObject(newobj4);
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            game.Update();
        }
    }
}
