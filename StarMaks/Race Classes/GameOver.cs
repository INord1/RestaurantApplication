using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMaks
{
    class GameOver:RaceProp
    {
        public Button btnCont { get; set; }
        public Button MainMenu { get; set; }
        public GameOver( PictureBox _myCar,PictureBox _pbEnemySpeed1, PictureBox _pbEnemySpeed2, PictureBox _pbEnemySpeed3, Label _lb,Timer _tm,
            Button _btnContinue, Button _btnMainMenu,SoundPlayer _sn)
        {
            myCar =_myCar; pbEnemySpeed1 = _pbEnemySpeed1; pbEnemySpeed2 = _pbEnemySpeed2;
            pbEnemySpeed3 = _pbEnemySpeed3; lb = _lb; tm = _tm; btnCont = _btnContinue;
            MainMenu = _btnMainMenu; sounds = _sn;
        }

        public void gameOverLogic(PictureBox myCarr,PictureBox enemy1,PictureBox enemy2, PictureBox enemy3,Timer time, Label lbS,
            Button btnProlong)
        {
            
            if (myCarr.Bounds.IntersectsWith(enemy1.Bounds) || myCarr.Bounds.IntersectsWith(enemy2.Bounds) || myCarr.Bounds.IntersectsWith(enemy3.Bounds))
            {
                sounds.Play();
                time.Enabled = false;
                lbS.Visible = true;
                btnCont.Visible = true;
                MainMenu.Visible = true;
              
              
            }
           
        }

        public void Gameoverrr()
        {

            gameOverLogic(myCar, pbEnemySpeed1, pbEnemySpeed2, pbEnemySpeed3, tm, lb,btnCont);
            

        }
    }
}
