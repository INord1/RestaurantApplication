using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMaks
{
    class Levels
    {
        public Label lbl { get; set; }
        public int speed { get; set; }
        public PictureBox myCar { get; set; }
     


        public Levels(int _speed,Label _lbl,PictureBox _myCar)
        {
            lbl = _lbl; speed = _speed; myCar = _myCar;
        }

      
        public void EventHandler(object sender, KeyEventArgs e) 
        {

           
                if (e.KeyCode == Keys.Left)
                {
                    if (myCar.Left > 0)

                        myCar.Left += -8;
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (myCar.Right < 400)
                        myCar.Left += 8;
                }

                
           
          


        }

       
    }
    }

