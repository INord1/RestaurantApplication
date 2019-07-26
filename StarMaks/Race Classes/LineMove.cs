using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace StarMaks
{
    class LineMove
    {
         public static void lineMove(int speed,PictureBox line1, PictureBox line2, PictureBox line3)
        {

           
            if (line1.Top >= 400 || line2.Top >= 400
                || line3.Top >= 400)
            {
                line1.Top = 0; line2.Top = 0; line3.Top = 0;
                
            }
            else { line1.Top += speed; line2.Top += speed; line3.Top += speed; }

            line1.Top += speed;
            line2.Top += speed;
            line3.Top += speed;


        }
    }
}
