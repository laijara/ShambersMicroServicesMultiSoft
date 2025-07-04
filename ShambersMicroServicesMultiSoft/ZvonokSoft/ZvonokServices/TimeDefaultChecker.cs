﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace ShambersMicroServicesMultiSoft.ZvonokSoft.ZvonokServices
{
    internal class TimeDefaultChecker
    {
        private SoundFunctions soundFunctions = new SoundFunctions();
        private List<Timer> activeTimers = new List<Timer>();
        private TimeDefault timeDefault = new TimeDefault();

        private TimeSpan checkday(TimeSpan time)
        {
            DateTime now = DateTime.Now;
            DateTime nextRun = now.Date.Add(time);
            if (nextRun < now)
            {
                nextRun = nextRun.AddDays(1);
            }
            return nextRun - now;
        }

        private void TimerGen(TimeSpan time)
        {
            TimeSpan delay = checkday(time);
            Timer timer = new Timer(_ =>
            {
                soundFunctions.PlayZvonok();
            }, null, delay, TimeSpan.FromHours(24));

            activeTimers.Add(timer);
        }

        public void TimerDefalut()
        {
            foreach (var timer in activeTimers)
            {
                timer?.Dispose();
            }
            activeTimers.Clear();
            
            TimerGen(timeDefault.timeListStart[1]);
            TimerGen(timeDefault.timeListStart[2]);
            TimerGen(timeDefault.timeListStart[3]);
            TimerGen(timeDefault.timeListStart[4]);
            TimerGen(timeDefault.timeListStart[5]);
            TimerGen(timeDefault.timeListStart[6]);
            TimerGen(timeDefault.timeListEnd[1]);
            TimerGen(timeDefault.timeListEnd[2]);
            TimerGen(timeDefault.timeListEnd[3]);
            TimerGen(timeDefault.timeListEnd[4]);
            TimerGen(timeDefault.timeListEnd[5]);
            TimerGen(timeDefault.timeListEnd[6]);
        }

        public void TimerStop()
        {
            foreach (var timer in activeTimers)
            {
                timer?.Dispose();
            }
            activeTimers.Clear();
        }
    }
}