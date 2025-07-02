using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShambersMicroServicesMultiSoft.ZvonokSoft.ZvonokServices
{
    internal class TimeDefault
    {
        SoundFunctions soundFunctions = new SoundFunctions();
        public readonly Dictionary<int, TimeSpan> timeList = new Dictionary<int, TimeSpan>
        {
            {1, TimeSpan.Parse("9:00:00")},
            {2, TimeSpan.Parse("10:40:00")},
            {3, TimeSpan.Parse("12:30:00")},
            {4, TimeSpan.Parse("14:05:00")},
            {5, TimeSpan.Parse("15:40:00")},
            {6, TimeSpan.Parse("17:15:00")},
            {7, TimeSpan.Parse("0:00:00")},
            {8, TimeSpan.Parse("0:00:00")},
            {9, TimeSpan.Parse("0:00:00")},
            {10, TimeSpan.Parse("10:30:00")},
            {11, TimeSpan.Parse("12:10:00")},
            {12, TimeSpan.Parse("14:00:00")},
            {13, TimeSpan.Parse("15:35:00")},
            {14, TimeSpan.Parse("17:10:00")},
            {15, TimeSpan.Parse("18:45:00")},
            {16, TimeSpan.Parse("0:00:00")},
            {17, TimeSpan.Parse("0:00:00")},
            {18, TimeSpan.Parse("0:00:00")},
        };
        private TimeSpan checkday(TimeSpan time)
        {
            DateTime now = DateTime.Now;
            DateTime nextRun = now.Date.Add(time);
            if (nextRun < now )
            {
                nextRun = nextRun.AddDays(1);
            }
            return nextRun - now;
        }
        private void TimerGen(TimeSpan time)
        {
            TimeSpan delay = checkday(time);
            new Timer(_ =>
            {
                soundFunctions.PlayZvonok();
            }, null, delay, TimeSpan.FromHours(24));
        }
        public void TimerDefalut()
        {
            TimerGen(timeList[1]);
            TimerGen(timeList[2]);
            TimerGen(timeList[3]);
            TimerGen(timeList[4]);
            TimerGen(timeList[5]);
            TimerGen(timeList[6]);
            TimerGen(timeList[10]);
            TimerGen(timeList[11]);
            TimerGen(timeList[12]);
            TimerGen(timeList[13]);
            TimerGen(timeList[14]);
            TimerGen(timeList[15]);

        }
    }
}
