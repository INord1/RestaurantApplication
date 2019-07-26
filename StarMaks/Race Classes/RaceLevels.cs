using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMaks
{
    class RaceLevels
    {
        object sender; KeyEventArgs e;
        public void Level1(int speedInGame,PictureBox car1)
        {
            
            if (e.KeyCode == Keys.Left)
            {
                if (car1.Left > 0)

                    car1.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car1.Right < 280)
                    car1.Left += 8;
            }

            if (e.KeyCode == Keys.Up)
                if (speedInGame < 21) speedInGame++;
            if (e.KeyCode == Keys.Down)
                if (speedInGame > 0) speedInGame--;
        }
        public void Level2(object sender, KeyEventArgs e,int speedInGame, PictureBox car1)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car1.Left > 0)

                    car1.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car1.Right < 280)
                    car1.Left += 8;
            }

            if (e.KeyCode == Keys.Up)
                if (speedInGame < 25) speedInGame++;
            if (e.KeyCode == Keys.Down)
                if (speedInGame > 0) speedInGame--;
        }


        
    }
}
