using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Nopan_heitto
{
    public partial class Form1 : Form
    {

        Image[] imgs = new Image[]
            {
                Properties.Resources.dice01,
                Properties.Resources.dice02,
                Properties.Resources.dice03,
                Properties.Resources.dice04,
                Properties.Resources.dice05,
                Properties.Resources.dice06
            };

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread mainThread = Thread.CurrentThread;
            //RollDice(Dice1PB);
            Thread thread1 = new Thread(()=> RollDice(Dice1PB));
            Thread thread2 = new Thread(() => RollDice(Dice2PB));
            Random rdm = new Random();
            int factorX = rdm.Next(10,100);
            thread1.Start();
            Thread.Sleep(factorX);
            thread2.Start();
        }
        


        private void RollDice(PictureBox dice)
        {

            Animation(dice);
            Random random = new Random();
            int dicenmb = random.Next(imgs.Length);
            dice.Image = imgs[dicenmb];

        }

        private void Animation(PictureBox dice)
        {
            for (int i = 0; i < 2; i++)
            {
                foreach(Image img in imgs)
                {
                    dice.Image = img;
                    Thread.Sleep(200);
                }
            }
        }

    }
}
