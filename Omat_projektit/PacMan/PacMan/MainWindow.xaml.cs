using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Threading;

namespace PacMan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer GameTimer = new DispatcherTimer();

        bool goLeft, goRight, goUp, goDown;
        bool noLeft, noRight, noUp, noDown;

        int Score;
        string direction;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void CanvasKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)
            {
                goLeft = true;
                goRight = goUp = goDown = false;
                
            }
            if(e.Key == Key.Right)
            {

                goRight = true;
                goLeft = goUp = goDown = false;
            }
            if(e.Key == Key.Up)
            {
                goLeft = false;
                goRight = false;
                goUp = true;
                goDown = false; 
            }
            if (e.Key == Key.Down)
            {
                goLeft = false;
                goRight = false;
                goUp = false;
                goDown = true;
            }

        }

        private void Movement()
        {
            if (goLeft == true && noLeft == true)
            {
                direction = "left";
            }
            if (goRight == true && noRight == true)
            {
                direction = "right";
            }
            if (goUp == true && noUp == true)
            {
                direction = "up";
            }
            else if (goDown == true && noDown == true)
            {
                direction = "down";
            }

            if direction == "Left";
            {

            }

        }


    }
}
