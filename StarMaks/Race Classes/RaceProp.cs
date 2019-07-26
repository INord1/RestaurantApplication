using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMaks
{
    class RaceProp
    {
        public int enemySpeed { get; set; }
        public PictureBox myCar { get; set; }
        public PictureBox pbEnemySpeed1 { get; set; }
       public  PictureBox pbEnemySpeed2 { get; set; }
       public PictureBox pbEnemySpeed3 { get; set; }
        public Label lb { get; set; }
        public Timer tm { get; set; }
        public Random rn { get; set; }
        public int x { get; set; }
        public PictureBox coin1 { get; set; }
        public PictureBox coin2 { get; set; }
        public PictureBox coin3 { get; set; }
        public PictureBox coin4 { get; set; }
        public int colCoins { get; set; }
        public SoundPlayer sounds { get; set; }





    }
}
