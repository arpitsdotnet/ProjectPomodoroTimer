using PomodoroTimer.ServiceLayer.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer.ServiceLayer.Timers
{
    public interface ISets
    {
        int Count { get; }
        bool IsAllSetsComplete { get; }
        bool IsSetsTypeWork { get; }

        SetsTypes SetsType { get; set; }

        void Initialize();
        void Increase();
    }
}
