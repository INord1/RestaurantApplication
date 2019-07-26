using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace StarMaks
{
    class Sounds
    {
        public SoundPlayer sound { get; set; }
        public Sounds(SoundPlayer _soundPlayer)
        {
            sound = _soundPlayer;
        }

        public void MakeAEngineSound()
        {
            sound = new SoundPlayer(Properties.Resources.BMW_DRIVEBY);
            sound.PlayLooping();
        }
    }
}
