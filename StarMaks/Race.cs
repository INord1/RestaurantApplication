
using NAudio.Wave;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Windows.Media;


namespace StarMaks
{
    public partial class Race : Form
    {
        MediaPlayer myPlayer = new MediaPlayer();
        
       
        private SoundPlayer coins;
         
        private SoundPlayer crash = new SoundPlayer(Properties.Resources.Car_Screech_And_Crash_SoundBible_com_1414562045);
        //private AudioFileReader sound1;

        Random r = new Random();
        int x;
        public Race()
        {
            InitializeComponent();
            lblGameOver.Visible = false;
            Levels levels = new Levels(speedInGame,lblCoins,car1);   
            OnButtonPress += levels.EventHandler;

           
          
        
            coins = new SoundPlayer(Properties.Resources.smb_powerup);
           


        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       private void Timer1_Tick(object sender, EventArgs e)
        {
            

            LineMove.lineMove(speedInGame, picLine1, picLine2, picLine3);
           
            // GameOver.Gameover(car1, enemy1, enemy2, timer1, lblGameOver,enemy3);
            GameOver gameOver = new GameOver(car1, enemy1, enemy2, enemy3, lblGameOver, timer1,btnConitue,btnMainMenu,crash);
            gameOver.Gameoverrr();
            
           Enemies enemy = new Enemies(speedInGame, enemy1, enemy2, enemy3, lblCoins,r,x);

            enemy.lblAssigment();
           



            Coins c = new Coins(car1, coin1, coin2, coin3, coin4, speedInGame, lblCoins);
            c.coins();

            coinsScore();





        }
        int colCoins = 0;
       
      
        void coinsScore()
        {

            
            if (car1.Bounds.IntersectsWith(coin1.Bounds))
            {
                colCoins++;
                coinScoreLogic(x, r, coin1);
                lblCoins.Text = colCoins.ToString();

                coins.Play();
                
               
            }
            if (car1.Bounds.IntersectsWith(coin2.Bounds))
            {
                colCoins++;
              
                coinScoreLogic(x, r, coin2);
                lblCoins.Text = colCoins.ToString();
                coins.Play();
            }
            if (car1.Bounds.IntersectsWith(coin3.Bounds))
            {
                colCoins++;
              
                coinScoreLogic( x, r, coin3);
                lblCoins.Text = colCoins.ToString();
                coins.Play();
            }
            if (car1.Bounds.IntersectsWith(coin4.Bounds))
            {
                colCoins++;
              
                coinScoreLogic( x, r, coin4);
                lblCoins.Text = colCoins.ToString();
                coins.Play();
            }
        }

        public void coinScoreLogic(int XY,Random rann,PictureBox coins)
        {
           // colCoinss++;
           // lblCoinss.Text = colCoinss.ToString();
            XY = rann.Next(0, 200);
            
            coins.Location = new Point(XY, 0);
        }
        int speedInGame = 0;

       
        public event KeyEventHandler OnButtonPress;
     
        private void Race_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
                if (speedInGame < 21)  speedInGame++; 

            if (e.KeyCode == Keys.Down)
                if (speedInGame > 0) speedInGame--;

        
            OnButtonPress?.Invoke(sender, e);



        }

        private void Race_Load(object sender, EventArgs e)
        {

        }

        private void BtnConitue_Click(object sender, EventArgs e)
        {
            
            Race startOver = new Race(); this.Hide(); startOver.ShowDialog();
        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            WelcomeWindow mN = new WelcomeWindow(); this.Hide(); mN.ShowDialog();
        }
    }

}
