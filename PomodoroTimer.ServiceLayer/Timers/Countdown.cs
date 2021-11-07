using PomodoroTimer.ServiceLayer.Constants;
using PomodoroTimer.ServiceLayer.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PomodoroTimer.ServiceLayer.Timers
{
    public sealed class Countdown : ICountdown
    {

        private static readonly Lazy<ICountdown> _instance = new Lazy<ICountdown>(() => new Countdown()); //private static Singleton singleInstance = null;  
        public static ICountdown Instance
        {
            get
            {
                return _instance.Value;
            }
        }
        private Countdown()
        {
            this.timer = new Timer();
            this.timer.Interval = StringConstant.IntervalFor1Second;
            this.timer.Elapsed += Timer_Elapsed;

            _sets = Sets.Instance;
            _sets.Initialize();

            SetWorkTimer();
        }

        // TIMER TICK EVENT
        public event EventHandler TickHappened;

        #region Private Fields
        private readonly Timer timer;

        private readonly ISets _sets;
        private int TimeLeft { get; set; } = 0;

        private int TimeLeftPrev { get; set; }


        #endregion

        #region Public Fields
        public bool IsTimeup => TimeLeft == 0;
        public int MinutesLeft => TimeLeft / StringConstant.SecondsPerMinute;
        public int SecondsLeft => TimeLeft % StringConstant.SecondsPerMinute;

        public int SetsCount => _sets.Count;
        public bool IsSetsTypeWork => _sets.IsSetsTypeWork;

        #endregion

        #region Private Methods

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            TimeLeft--;

            if (this.IsTimeup)
            {
                StopCountdown();

                // Event does not firing
                //if (_sets.IsSetsTypeWork == false)
                //{
                //    // Work has started Or Break has finished
                //    SetWorkTimer();
                //}
                //else
                //{
                //    // Break has started Or Work has finished
                //    SetBreakTimer();
                //}
            }
            TickHappened?.Invoke(this, EventArgs.Empty);
        }

        private void Initialize(int minutesToSet)
        {
            TimeLeft = minutesToSet * StringConstant.SecondsPerMinute;
        }

        public void ResetTime()
        {
            Initialize(TimeLeftPrev);
        }


        #endregion

        #region Public Methods


        public void StartCountdown()
        {
            this.timer.Start();
        }

        public void StopCountdown()
        {
            this.timer.Stop();
        }

        public void SetWorkTimer()
        {
            _sets.SetsType = SetsTypes.Work;
            _sets.Increase();

            int time = StringConstant.pomodoroWorkMinutes;

            Initialize(time);
            TimeLeftPrev = time;
        }
        public void SetBreakTimer()
        {
            _sets.SetsType = SetsTypes.Break;
            int time = StringConstant.pomodoroShortBreakMinutes;

            if (_sets.IsAllSetsComplete == true)
            {
                _sets.Initialize();
                time = StringConstant.pomodoroLongBreakMinutes;
            }

            Initialize(time);
            TimeLeftPrev = time;
        }

        #endregion
    }
}
