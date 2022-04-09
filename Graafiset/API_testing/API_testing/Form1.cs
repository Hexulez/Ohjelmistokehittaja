using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace API_testing
{
    public partial class Main : Form
    {
        private int maxNumber = 0;
        private int currentNumber= 0;
        public Main()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
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

        private async void Main_Load(object sender, EventArgs e)
        {
            await LoadImage();
        }

        private  async void NextBT_Click(object sender, EventArgs e)
        {
            if (currentNumber < maxNumber)
            {
                currentNumber += 1;
                PreviousBT.Enabled = true;
                await LoadImage(currentNumber);
                


                if (currentNumber == 1)
                {
                    NextBT.Enabled = false;
                }
            }

        }

        private async void PreviousBT_Click(object sender, EventArgs e)
        {
            if (currentNumber > 1)
            {
                currentNumber -= 1;
                //testi.Text = currentNumber.ToString();
                NextBT.Enabled = true;
                try
                {
                    await LoadImage(currentNumber);

                }
                catch (Exception ) { }
                comicImage.Refresh();
                
                

                if (currentNumber == 1)
                {
                    PreviousBT.Enabled = false;
                }
            }
        }
    
    }
}
