using PomodoroTimer.ServiceLayer.Constants;
using PomodoroTimer.ServiceLayer.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer.ServiceLayer.Timers
{
    public class Sets : ISets
    {
        private static readonly Lazy<ISets> _instance = new Lazy<ISets>(() => new Sets()); //private static Singleton singleInstance = null;  
        public static ISets Instance
        {
            get
            {
                return _instance.Value;
            }
        }
        private Sets()
        {
        }


        // ROUND LOGIC
        public int Count { get; private set; }
        public bool IsAllSetsComplete => Count == StringConstant.pomodoroSetsMax;
        public bool IsSetsTypeWork => SetsType == SetsTypes.Work;

        public SetsTypes SetsType { get; set; }

        public void Initialize()
        {
            Count = 0;
        }

        public void Increase()
        {
            Count++;
        }
    }
}
