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
        GameFactory gameFactory = GameFactory.GetOneGameFactory();
        MoveKeyBoard keyBoardControl = new MoveKeyBoard();
        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            picBox4.Hide();

            //Getting Keyboard Movement from factory
            GameObject newobj = gameFactory.CreateGameObject(picBox, 4, Movement.Keyboard, ObjectsType.player);

            //Getting Right Movement from factory
            GameObject newobj2 = gameFactory.CreateGameObject(picBox2, 1, Movement.Right, ObjectsType.enemy);

            //Default left movement,if movement not specified
            GameObject newobj3 = gameFactory.CreateGameObject(picBox3, 4, ObjectsType.enemy);

            game.addGameObject(newobj);
            game.addGameObject(newobj2);
            game.addGameObject(newobj3);
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            game.Update();
        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                keyBoardControl.KeyDown(MMentKeys.Left);
            }

            else if (e.KeyCode == Keys.Right)
            {
                keyBoardControl.KeyDown(MMentKeys.Right);
            }
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                keyBoardControl.KeyUp(MMentKeys.Left);
            }

            else if (e.KeyCode == Keys.Right)
            {
                keyBoardControl.KeyUp(MMentKeys.Right);
            }
        }
    }
}