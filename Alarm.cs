using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501
{
    public class Alarm
    {
        private DateTime _alarmTime;

        public DateTime AlarmTime
        {
            get => _alarmTime;
            set => _alarmTime = value;
        }

        private bool _alarmState = false;

        public bool AlarmState
        {
            get => _alarmState;
            set => _alarmState = value;
        }
        public override string ToString()
        {
            string state;

            if (AlarmState)
            {
                state = "On";
            }
            else
            {
                state = "Off";
            }

            return string.Format("{0:t} " + state, AlarmTime);
        }
    }
}