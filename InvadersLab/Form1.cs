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
        public Form1()
        {
            InitializeComponent();
            stars = new Stars(new Random(), this.ClientRectangle);
            game = new Game(new Random(), this.ClientRectangle);
            animationTimer.Start();
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
        
    }
}
