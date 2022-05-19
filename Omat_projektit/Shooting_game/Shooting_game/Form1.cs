using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shooting_game
{
    public partial class shootingGameFM : Form
    {
        public shootingGameFM()
        {
            InitializeComponent();
        }
        Random random = new Random();
        List<PictureBox> zombies = new List<PictureBox>();
        List <PictureBox> ammo = new List<PictureBox>();
        bool goLeft, goRight, goDown, goUp;
        int playerMoving = 10;

        private void Moving()
        {
            if (goLeft) PlayerPB.Left -= playerMoving;
            if (goRight) PlayerPB.Left += playerMoving;
            if (goUp) PlayerPB.Top -= playerMoving;
            if (goDown) PlayerPB.Top += playerMoving; 
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Moving();
        }

        private void shootingGameFM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { goLeft = true; }
            if (e.KeyCode == Keys.Right) { goRight = true; }
            if (e.KeyCode == Keys.Up) { goUp = true; }
            if (e.KeyCode == Keys.Down) { goDown = true; }
        }

        private void shootingGameFM_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { goLeft = false; }
            if (e.KeyCode == Keys.Right) { goRight = false; }
            if (e.KeyCode == Keys.Up) { goUp = false; }
            if (e.KeyCode ==Keys.Down) { goDown = false; }
        }

        private void shootingGameFM_MouseMove(object sender, MouseEventArgs e)
        {
            AimingPB.Location = e.Location;
        }

        private void Shooting()
        {
            int startX = PlayerPB.Location.X;
            int startY = PlayerPB.Location.Y;
            int endX = AimingPB.Location.X;
            int endY = AimingPB.Location.Y;
            int flyX = startX - endX;
            int flyY = startY - endY;
            if (flyX < flyY)
            {
                //float littleMove = (flyX - flyY) / (flyY - flyX);
                float littleMove = flyX / flyY;
            }

        }
    }
}
