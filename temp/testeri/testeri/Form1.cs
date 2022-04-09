using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace testeri
{
    public partial class Form1 : Form
    {

        private int maxNumber = 0;
        private int currentNumber = 0;
        public Form1()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            //nextImageButton.IsEnabled = false;
        }

        private async Task LoadImage(int imageNumber = 0)
        {
            var comic = await ComicProcessor.LoadComic(imageNumber);

            if (imageNumber == 0)
            {
                maxNumber = comic.Num;
            }

            currentNumber = comic.Num;

            var uriSource = new Uri(comic.Img, UriKind.Absolute);
            comicImage.ImageLocation = uriSource.ToString();
            
        }

        

      
        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadImage();
        }

        private async void previousImageButton_Click(object sender, EventArgs e)
        {
            if (currentNumber > 1)
            {
                currentNumber -= 1;
                nextImageButton.Enabled = true;
                await LoadImage(currentNumber);

                if (currentNumber == 1)
                {
                    previousImageButton.Enabled = false;
                }
            }

        }

        private async void nextImageButton_Click(object sender, EventArgs e)
        {
            if (currentNumber < maxNumber)
            {
                currentNumber += 1;
                previousImageButton.Enabled = true;
                await LoadImage(currentNumber);

                if (currentNumber == maxNumber)
                {
                    nextImageButton.Enabled = false;
                }
            }
        }
    }
}
