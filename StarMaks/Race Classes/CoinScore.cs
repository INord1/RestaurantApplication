using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StarMaks
{
    class CoinScore:RaceProp
    {

        public CoinScore(PictureBox _car1,PictureBox _coin1, PictureBox _coin2, PictureBox _coin3, PictureBox _coin4,
            Label _lblcoins,Random _rn,int _x,int _colCoins)
        {
            myCar = _car1; coin1 = _coin1; coin2 = _coin2;coin3 = _coin3;coin4 = _coin4;
            lb = _lblcoins; rn = _rn;x = _x; colCoins = _colCoins;
        }


        public static void coinsScore(PictureBox car1,PictureBox coin1,PictureBox coin2,
            PictureBox coin3,PictureBox coin4,Label lblCoins)
        {
            int x; Random r = new Random(); int colCoins = 0;
            if (car1.Bounds.IntersectsWith(coin1.Bounds)|| car1.Bounds.IntersectsWith(coin2.Bounds)
                || car1.Bounds.IntersectsWith(coin3.Bounds)|| car1.Bounds.IntersectsWith(coin4.Bounds))
            {
                colCoins++;
                lblCoins.Text = colCoins.ToString();
                x = r.Next(0, 200);

                coin1.Location = new Point(x, 0); coin2.Location = new Point(20, 0);
                coin2.Location = new Point(40, 0); coin2.Location = new Point(50, 0);
            }
            //if (car1.Bounds.IntersectsWith(coin2.Bounds))
            //{
            //    colCoins++;
            //    lblCoins.Text = colCoins.ToString();
            //    x = r.Next(0, 200);

            //    coin2.Location = new Point(x, 0);
            //}
            //if (car1.Bounds.IntersectsWith(coin3.Bounds))
            //{
            //    colCoins++;
            //    lblCoins.Text = colCoins.ToString();
            //    x = r.Next(0, 200);

            //    coin3.Location = new Point(x, 0);
            //}
            //if (car1.Bounds.IntersectsWith(coin4.Bounds))
            //{
            //    colCoins++;
            //    lblCoins.Text = colCoins.ToString();
            //    x = r.Next(0, 200);

            //    coin4.Location = new Point(x, 0);
            //}
        }
        public void coinCount()
        {
            if (myCar.Bounds.IntersectsWith(coin1.Bounds))
            {
                logicCoinScore(myCar,coin1,lb,rn,x,colCoins);
            }
            if (myCar.Bounds.IntersectsWith(coin2.Bounds))
            {
                logicCoinScore(myCar, coin2, lb, rn, x, colCoins);
            }
            if (myCar.Bounds.IntersectsWith(coin3.Bounds))
            {
                logicCoinScore(myCar, coin3, lb, rn, x, colCoins);
            }
            if (myCar.Bounds.IntersectsWith(coin4.Bounds))
            {
                logicCoinScore(myCar, coin4, lb, rn, x, colCoins);
            }
        }




        public void logicCoinScore(PictureBox c1, PictureBox co1,Label lalbeScoreee,Random r, int w, int coinsss)
        {
           
                coinsss++;
                lalbeScoreee.Text = coinsss.ToString();
                 w = r.Next(0, 200);

                co1.Location = new Point(w, 0);
            
        }
    }
}
