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
        

        private void enemyTimer_Tick(object sender, EventArgs e)
        {
            makeEnemy();

            foreach (PictureBox item in enemyList.ToList())
            {
                item.Left -= enemyMove;
                if (myCar.Bounds.IntersectsWith(item.Bounds))
                {
                    MessageBox.Show("pöö");
                }

                
                if (item.Left <10)
                {
                   
                    enemyList.Remove(item);
                    this.Controls.Remove(item);
                    points++;
                }
                
            }
        }

       

        private void carTimer_Tick(object sender, EventArgs e)
        {
            if (goUp)
            {
                myCar.Top -= playerMove;
            }
            else if (goDown)
            {
                myCar.Top += playerMove;
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
        }

        private void makeEnemy()
        {
            spawner--;
            if (spawner == 0)
            {
                PictureBox enemy = new PictureBox();

                enemy.Width = 50;
                enemy.Height = 50;
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

    }
}
