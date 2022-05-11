using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Sommer.BL
{
    [Serializable]
    public class TimerClasses
    {
        private TimerClasses()
        {

        }

        public List<TimerClass> Timers = new List<TimerClass>();

        private static TimerClasses _timerClasses;
        public static TimerClasses Instance            
        { 
            get
            {
                if(_timerClasses == null)
                    _timerClasses = new TimerClasses();

                return _timerClasses;
            }
        }
    }
}
