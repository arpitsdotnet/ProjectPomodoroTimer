using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer.ServiceLayer.Constants
{
    public class StringConstant
    {
        public const string ApplicationTitle = "Pomodoro Timer by Arpit";

        // ONE SET = (25 + 5) + (25 + 5) + (25 + 20) = 70 Works + 30 Break = 100 Hours
        //public const int pomodoroWorkMinutes = 1; // DEFAULT : 25
        //public const int pomodoroShortBreakMinutes = 1; // DEFAULT : 5
        //public const int pomodoroLongBreakMinutes = 1; // DEFAULT : 20
        //public const int pomodoroSetsRound = 1; // DEFAULT : 2 (WORK + BREAK)
        //public const int pomodoroSetsMax = 2 * pomodoroSetsRound; // DEFAULT : 3

        //public const int IntervalFor1Second = 100; // DEFAULT : 1000
        //public const int SecondsPerMinute = 60; // DEFAULT : 60


        public const int pomodoroWorkMinutes = 25; // DEFAULT : 25
        public const int pomodoroShortBreakMinutes = 5; // DEFAULT : 5
        public const int pomodoroLongBreakMinutes = 20; // DEFAULT : 20
        public const int pomodoroSetsRound = 1; // DEFAULT : 2 (WORK + BREAK)
        public const int pomodoroSetsMax = 3 * pomodoroSetsRound; // DEFAULT : 3

        public const int IntervalFor1Second = 1000; // DEFAULT : 1000
        public const int SecondsPerMinute = 60; // DEFAULT : 60

        public const string WorkSoundLocation = @"c:\Windows\Media\Ring06.wav";
        public const string BreakSoundLocation = @"c:\Windows\Media\Ring08.wav";
    }
}
