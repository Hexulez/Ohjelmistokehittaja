using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace PicBox_Test_Chamber
{
    public partial class carGame : Form
    {
        public carGame()
        {
            InitializeComponent();
        }
        bool goLeft, goRight, goUp = false, goDown = false;
        int x,y, playerMove = 10;
        Random random = new Random();

        private void enemyTimer_Tick(object sender, EventArgs e)
        {
            MakeEnemy();
        }

        List<PictureBox> enemyList = new List<PictureBox>();


        //player movement
        private void TicTocTimer_Tick(object sender, EventArgs e)
        {
            if (goUp == true)
            {
                myCar.Top -= playerMove;
            }
            else if (goDown == true)
            {
                myCar.Top += playerMove;
            }


        }
        

       

        private void carGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
            else if (e.KeyCode== Keys.Left)
            {
                goLeft = true;
            }
            else if (e.KeyCode== Keys.Right) 
            { 
                goRight = true; 
            }

        }

        private void carGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            else if (e.KeyCode== Keys.Left)
            {
                goLeft = false;
            }
            else if (e.KeyCode== Keys.Right)
            {
                goRight = false;
            }
        }
        //player movement end
        private void MakeEnemy()
        {
            PictureBox enemy = new PictureBox();
            enemy.Width =   50;
            enemy.Height = 50;
            enemy.BackColor = Color.Blue;

            x = this.ClientSize.Width - enemy.Width;
            y = random.Next(10, this.ClientSize.Height - enemy.Height);
            
            enemy.Location = new Point(x, y);
            enemyList.Add(enemy);
            this.Controls.Add(enemy);


        }


    }
}
