using System;
using System.Collections.Generic;
using System.Drawing;

using System.Windows.Forms;

using System.Drawing.Imaging; // add this for the JPG compressor

namespace Snake_game
{
    public partial class Form1 : Form
    {

        private List<Circle> Snake = new List<Circle>(); //Tekee uuden lista muuttujan jossa määritetään että tyyppi on Circle
        private Circle food = new Circle();     //Circle luokan muuttuja

        int maxWidth, maxHeight, score, highScore; //tekee kasan int muutujia

        Random rand = new Random(); //tekee random muuttujan

        bool goLeft, goRight, goUp, goDown; //kasa bool muuttujia




        public Form1()
        {
            InitializeComponent();

            new Settings(); //luo uuden Kopion settings luokasta
        }

        private void KeyIsDown(object sender, KeyEventArgs e) // tapahtumat jos näppäin on pohjassa.
        {

            if (e.KeyCode == Keys.Left && Settings.directions != "right")  //jos painetaan vasenta näppäintä ja suunta ei ole oikea
            {
                goLeft = true;      //muuttaa bool muuttujan arvon
            }

            else if (e.KeyCode == Keys.Right && Settings.directions != "left")  //päättele loput itse edellisestä.
            {
                goRight = true;
            }

            else if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            else if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }


        }

        private void KeyIsUp(object sender, KeyEventArgs e) //jos näppäin nousee takaisin ylös
        {

            if (e.KeyCode == Keys.Left ) 
            {
                goLeft = false; //bool muuttuja muuttuu takaisin oletus false arvoon
            }

            else if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            else if (e.KeyCode == Keys.Up )
            {
                goUp = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }


        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();  //kutsuu metodin
        }


        //ottaa kuvan kaappauksen pelin lopputuloksesta ja lisää siihen tekstin
        private void TakeSnapShot(object sender, EventArgs e)
        {
            //tekstin osuus
            Label caption = new Label();    //luo uuden label teksti kentän
            caption.Text = "I scored: " + score + " and my Highscore is " + highScore + " on the Snake Game"; //muuttaa sen tekstin
            caption.Font = new Font("Ariel", 12, FontStyle.Bold);   //fontin tyyppi
            caption.ForeColor = Color.Purple;   //fontin väri
            caption.AutoSize = false;   //ei sovita automaattisesti
            caption.Width = gameboard.Width; //asettaa leveyden
            caption.Height = 30; //asettaa korkeuden
            caption.TextAlign = ContentAlignment.MiddleCenter;//keskittää tekstin
            gameboard.Controls.Add(caption); //lisää sen tekstin kuvaan


            SaveFileDialog dialog = new SaveFileDialog();   //luo dialog muuttujan
            dialog.FileName = "Snake Game SnapShot";    //tiedoston oletusnimi
            dialog.DefaultExt = "jpg";  //oletus formaatti
            dialog.Filter = "JPG Image File | *.jpg";   //vaihtoehdot mihin muotoon kuvan voi tallentaa
            dialog.ValidateNames = true;    //tarkistaa että tiedoston nimi on hyväksytyssä asussa

            if (dialog.ShowDialog() == DialogResult.OK) //jos kaikki on ok
            {
                int width = Convert.ToInt32(gameboard.Width);   //muuttaa pelilaudan leveyden numeroiksi
                int height = Convert.ToInt32(gameboard.Height); //muuttaa pelilaudan korkeuden numeroiksi
                Bitmap bmp = new Bitmap(width, height); //luo uuden bitmapin
                gameboard.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));    //piirtää pelin kuvan bitmappiin
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);    //tallentaa kuvan jpg formaattiin
                gameboard.Controls.Remove(caption); //poistaa pelipöydästä tekstin
            }



        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

            //setting directions 
            //tarkistaa mikä on näppäinpainalluksen tila
            if (goLeft)     
            {
                Settings.directions = "left";   //asettaa halutun suunnan käärmeelle. mikä tarkistetaan myöhemmin
            }

            if (goRight)
            {
                Settings.directions = "right";
            }

            if (goUp)
            {
                Settings.directions = "up";
            }

            if (goDown)
            {
                Settings.directions = "down";
            }

            //end directions


            for (int i = Snake.Count -1; i >= 0; i--)
            {
                if (i == 0) // jos i muutujan arvo on 0 (eli käärmeen pää)
                {

                    //päättää mihin suuntaan mennään
                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--; //liikuttaa käärmeen päätä
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                    }

                    //vie käärmeen reunalta toiselle
                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }

                    //jos pää ja ruoka samassa paikkaa
                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }

                    //jos pää ja ruumis samassa kohdassa
                    for (int j = 1; j < Snake.Count; j++)
                    {

                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                    
                }

                //muuttaa muun ruumiin paikkaa
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            gameboard.Invalidate(); //piirtää muutokset picture boxiin

        }

        //picture boxin 
        private void UpdateGameBoard(object sender, PaintEventArgs e)
        {

            Graphics canvas = e.Graphics;

            Brush snakeColour; //luo muuttujan millä määritellään myöhemmin pallojen väri

            for (int i = 0; i < Snake.Count; i++)
            {

                if (i == 0)
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = Brushes.DarkGreen;
                }

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));


            }


            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
                (
                food.X * Settings.Width,
                food.Y * Settings.Height,
                Settings.Width, Settings.Height
                ));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //käynnistää pelin
        private void RestartGame()
        {
            maxWidth = gameboard.Width / Settings.Width - 1;
            maxHeight = gameboard.Height / Settings.Height - 1;

            Snake.Clear();

            startBT.Enabled = false;
            snapBT.Enabled = false;
            score = 0;
            ScoreLB.Text = "Score: " + score;

            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head); //Lisää pään osan käärmeestä listaan

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }
            //debuglines
            debugLB.Text = Snake[0].X + " & " + Snake[2].X;
            debugLB2.Text = Snake[0].Y + " & " + Snake[2].Y;

            food = new Circle {X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight)};

            gameTimer.Start();




        }

        private void EatFood()
        {
            score++;

            ScoreLB.Text = "Score: " + score;

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food= new Circle { X= rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight)};



        }

        private void GameOver()
        {
            gameTimer.Stop();
            startBT.Enabled = true;
            snapBT.Enabled=true;

            if (score > highScore)
            {
                highScore = score;

                HiScoreLB.Text = "High Score: " + Environment.NewLine + highScore;
                HiScoreLB.ForeColor = Color.Maroon;
                HiScoreLB.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

    }
}
