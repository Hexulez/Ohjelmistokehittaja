using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class CarGame : Form
    {
        public CarGame()
        {
            InitializeComponent();
        }
        List<PictureBox> enemyList = new List<PictureBox>();
        Random random = new Random();
        bool goUp, goDown, goLeft, goRight;
        int playerMove = 10;
        int enemyMove = 5;
        int x, y, points;
        int spawner = 50, spawnerReset = 50;
        //int[] difficulty = { 45, 40, 35, 30, 25, 20, 15, 10 };
        Dictionary<int, int> difficulty = new Dictionary<int, int>()
        {
            {10, 45},
            {20, 40},
            {30, 35},
            {40, 30},
            {50, 25},
            {60, 20},
            {70, 15},
            {80, 10}
        };
        Dictionary<int, int> speed = new Dictionary<int, int>()
        {
            {5, 90},
            {15, 80},
            {25, 70},
            {35, 60},
            {45, 50},
            {55, 40},
            {65, 30},
            {75, 20}
        };

        private void enemyTimer_Tick(object sender, EventArgs e)
        {
            makeEnemy();
            /*
            if (myCar.Top < 10 || myCar.Top > 330)
            {
                makeBorder();
            }
            */
            foreach (PictureBox item in enemyList.ToList())
            {
                item.Left -= enemyMove;
                if (myCar.Bounds.IntersectsWith(item.Bounds))
                {
                    enemyTimer.Stop();
                    playAgainBT.Visible = true;
                    playAgainBT.Enabled = true;
                }

                
                if (item.Left <10)
                {
                   
                    enemyList.Remove(item);
                    this.Controls.Remove(item);
                    points++;
                    PointsLB.Text = "Points " + points;
                }
                
            }
            try
            {
                spawnerReset = difficulty[points];
                enemyTimer.Interval = speed[points];
            }
            catch (Exception ex) { };
            
            
        }


        private void PlayAgain(object sender, EventArgs e)
        {
            spawner = 50;
            spawnerReset = 50;
            points = 0;
            PointsLB.Text = "Points: " + points;
            enemyTimer.Interval = 100;
            foreach (PictureBox item in enemyList.ToList())
            {
                enemyList.Remove(item);
                this.Controls.Remove(item);
            }
            playAgainBT.Visible = false;
            playAgainBT.Enabled = false;
            enemyTimer.Start();
            
        }


        private void carTimer_Tick(object sender, EventArgs e)
        {
            if (goUp)
            {
                
                if (myCar.Top > 0)
                {
                    myCar.Top -= playerMove;
                }
                
            }
            else if (goDown)
            {
                if (myCar.Top < 330)
                {
                    
                    myCar.Top += playerMove;
                }
                
            }
            else if (goLeft)
            {
                if (myCar.Left > 0)
                {
                    myCar.Left -= playerMove;
                }
            }
            else if (goRight)
            {
                if (myCar.Left < 600)
                {
                    
                    myCar.Left += playerMove;
                }

}
        }

        private void CarGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                
                goUp = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Left)
            {

                goLeft = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void CarGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                goRight= false;
            }
        }

        private void makeEnemy()
        {
            spawner--;
            if (spawner == 0)
            {
                PictureBox enemy = new PictureBox();

                enemy.Width = 50;
                enemy.Height = 200;
                enemy.BackColor = Color.Red;

                x = this.ClientSize.Width - enemy.Width;
                y = random.Next(ClientSize.Height - enemy.Height);
                enemy.Location = new Point(x, y);
                //enemy.Size = new Size(x, y);

                enemyList.Add(enemy);
                this.Controls.Add(enemy);

                spawner = spawnerReset;
            }

           
            
        }

        private void makeBorder()
        {
            PictureBox enemy = new PictureBox();

            enemy.Width = 50;
            enemy.Height = 30;
            enemy.BackColor = Color.Red;

            
            enemy.Location = new Point(this.ClientSize.Width - enemy.Width, 10);
            enemyList.Add(enemy);
            this.Controls.Add(enemy);

            enemy.Location = new Point(this.ClientSize.Width - enemy.Width, 300);
            enemyList.Add(enemy);
            this.Controls.Add(enemy);

            
        }
    }
}
