using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace StarMaks
{
 class Enemies:RaceProp
    {
        // volumehttps://social.msdn.microsoft.com/Forums/vstudio/en-US/42b46e40-4d4a-48f8-8681-9b0167cfe781/attenuating-soundplayer-volume?forum=csharpgeneral
        public Enemies(int _enemySpeed, PictureBox _pbEnemySpeed1, PictureBox _pbEnemySpeed2, PictureBox _pbEnemySpeed3, Label _lb,
           Random _rn,int _x )
        {
            enemySpeed = _enemySpeed; pbEnemySpeed1 = _pbEnemySpeed1; pbEnemySpeed2 = _pbEnemySpeed2;
            pbEnemySpeed3 = _pbEnemySpeed3; lb = _lb;rn = _rn;x = _x;
        }


        public  void lvlLogic(int a, Random rnn, PictureBox enemy)
        {
            

            if (enemy.Top >= 350)
            {
                a = rnn.Next(0, 100);
                enemy.Location = new Point(a, 0);


            }

        }
        public void lblAssigment()
        {
            

            
                //if (lb.Text == 1.ToString())
                    level1();
               // if(lb.Text == 2.ToString())
                  level2();

                  level3();



        }

        public  void level1()
        {
            pbEnemySpeed1.Visible = true;
            if (pbEnemySpeed1.Top >= 350)
            {
               
                lvlLogic(x, rn, pbEnemySpeed1);
            }
            else { pbEnemySpeed1.Top += enemySpeed;  }
        }
        
        public void level2()
        {
             pbEnemySpeed2.Visible = true;
            if (pbEnemySpeed2.Top >= 450)
            {

                lvlLogic(x, rn, pbEnemySpeed2);
            }
            else { pbEnemySpeed2.Top += enemySpeed; }
        }
        public void level3()
        {
           pbEnemySpeed3.Visible = true;
            if (pbEnemySpeed3.Top >= 450)
            {

                lvlLogic(x, rn, pbEnemySpeed3);
            }
            else { pbEnemySpeed3.Top += enemySpeed; }
        }

      
    }
}
