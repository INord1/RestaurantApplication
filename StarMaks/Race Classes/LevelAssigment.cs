using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMaks
{
    class LevelAssigment:RaceProp
    {
        public LevelAssigment(int _enemySpeed, PictureBox _pbEnemySpeed1, PictureBox _pbEnemySpeed2, PictureBox _pbEnemySpeed3)
        {
            enemySpeed = _enemySpeed; pbEnemySpeed1 = _pbEnemySpeed1; pbEnemySpeed2 = _pbEnemySpeed2;
            pbEnemySpeed3 = _pbEnemySpeed3;
        }
       
        public void phaseLogic()
        {
            if(lb.Text==5.ToString())
            {

            }
        }


    }
}
