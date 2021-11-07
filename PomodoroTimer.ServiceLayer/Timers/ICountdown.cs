using PomodoroTimer.ServiceLayer.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer.ServiceLayer.Timers
{
    public interface ICountdown
    {
        int MinutesLeft { get; }
        int SecondsLeft { get; }
        bool IsTimeup { get; }

        int SetsCount { get; }
        bool IsSetsTypeWork { get; }

        /// <summary>
        /// Timer will initialized with the Work / Break Time from start.
        /// </summary>
        void ResetTime();

        void StartCountdown();
        void StopCountdown();

        event EventHandler TickHappened;

        void SetWorkTimer();
        void SetBreakTimer();
    }
}
