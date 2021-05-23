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
        MoveKeyBoard keyBoardControl = new MoveKeyBoard();
        public GameWindow()
        {
            InitializeComponent();
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            picBox4.Hide();
            //Factory Object
            MovementFactory obj = new MovementFactory();

            //Getting Keyboard Movement from factory
            IMovement keyBoard = obj.getMovement(Movement.Keyboard);
            GameObject newobj = new GameObject(picBox, 4, keyBoard);

            //Getting Right Movement from factory
            IMovement newRight = obj.getMovement(Movement.Right);
            GameObject newobj2 = new GameObject(picBox2, 1, newRight);

            //Default left movement,if movement not specified
            GameObject newobj3 = new GameObject(picBox3, 3);

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