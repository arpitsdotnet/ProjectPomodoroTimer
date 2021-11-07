using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer.ServiceLayer.Sounds
{
    public interface IAlarm
    {
        void PlaySound(string soundLocation);
    }
}
