using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvadersLab
{
    public partial class Form1 : Form
    {
        Stars stars;
        Game game;
        bool gameOver;
        public Form1()
        {
            InitializeComponent();
            stars = new Stars(new Random(), this.ClientRectangle);
            game = new Game(new Random(), this.ClientRectangle);
            animationTimer.Start();
            gameTimer.Start();
            gameOver = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            game.Draw(CreateGraphics());
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            game.Twinkle();
            game.Draw(CreateGraphics());
            //this.Refresh();
        }

        List<Keys> keysPressed = new List<Keys>();

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                Application.Exit();
            }
            else if (gameOver)
            {
                if (e.KeyCode == Keys.S)
                {
                    // reset game.
                    return; //?
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                //game.FireShot();
            }
            else if (keysPressed.Contains(e.KeyCode))
            {
                keysPressed.Remove(e.KeyCode);
            }

            keysPressed.Add(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keysPressed.Contains(e.KeyCode))
            {
                keysPressed.Remove(e.KeyCode);
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //game.Go();
            foreach (var key in keysPressed)
            {
                if (key == Keys.Left)
                {
                    game.MovePlayer(Direction.Left);
                }
                else if (key == Keys.Right)
                {
                    game.MovePlayer(Direction.Right);
                }
            }
        }
        
    }
}
