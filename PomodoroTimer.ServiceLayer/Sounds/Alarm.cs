using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer.ServiceLayer.Sounds
{
    public class Alarm : IAlarm
    {
        public void PlaySound(string soundLocation)
        {
            using (var soundPlayer = new SoundPlayer(soundLocation))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
        }
    }
}
