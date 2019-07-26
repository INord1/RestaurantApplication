using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMaks
{
    class Coins

    {
        private PictureBox car1 { get; set; }
        private PictureBox pbCoin1 { get; set; }
        private PictureBox pbCoin2 { get; set; }
        private PictureBox pbCoin3 { get; set; }
        private PictureBox pbCoin4 { get; set; }
        private int speed { get; set; }
        private Label lblCoins { get; set; }

        

        int x; Random r = new Random(); int colCoins = 0;

        public Coins(PictureBox _car1,PictureBox _pbCoins1, PictureBox _pbCoins2, PictureBox _pbCoins3
            , PictureBox _pbCoins4,int _speed,Label _lblCoins)
        {
            car1 = _car1; pbCoin1 = _pbCoins1;pbCoin2 = _pbCoins2;pbCoin3 = _pbCoins3;pbCoin4 = _pbCoins4;
            speed = _speed; lblCoins = _lblCoins;
        }

       
        public void coins()
        {
          
            if (pbCoin1.Top >= 400)
            {
                x = r.Next(0, 200);

                pbCoin1.Location = new Point(x, 0); 
            }
            if(pbCoin2.Top >= 400)
            {
                x = r.Next(0, 200);

                pbCoin2.Location = new Point(x, 0);
            }
            if(pbCoin3.Top >= 400)
            {
                x = r.Next(0, 200);

                pbCoin3.Location = new Point(x, 0);
            }
            if (pbCoin4.Top >= 400)
            {
                x = r.Next(0, 200);

                pbCoin4.Location = new Point(x, 0);
            }

            else { pbCoin1.Top += speed; pbCoin2.Top += speed;
                pbCoin3.Top += speed; pbCoin4.Top += speed;
            }
        }
      
      
        }

    }

