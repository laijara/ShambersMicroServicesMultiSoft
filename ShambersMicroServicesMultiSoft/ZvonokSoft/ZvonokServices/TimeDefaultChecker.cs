using System;
using System.Collections.Generic;
using System.Threading;

namespace ShambersMicroServicesMultiSoft.ZvonokSoft.ZvonokServices
{
    internal class TimeDefaultChecker
    {
        private SoundFunctions soundFunctions = new SoundFunctions();
        private List<Timer> activeTimers = new List<Timer>(); // Добавлено для хранения таймеров
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
            if (time == TimeSpan.Zero) return; // Пропускаем нулевое время

            TimeSpan delay = checkday(time);
            Timer timer = new Timer(_ =>
            {
                soundFunctions.PlayZvonok();
            }, null, delay, TimeSpan.FromHours(24));

            activeTimers.Add(timer); // Сохраняем таймер
        }

        public void TimerDefalut()
        {
            // Очищаем старые таймеры
            foreach (var timer in activeTimers)
            {
                timer?.Dispose();
            }
            activeTimers.Clear();

            // Создаем новые таймеры
            TimerGen(timeDefault.timeList[0]);
            TimerGen(timeDefault.timeList[1]);
            TimerGen(timeDefault.timeList[2]);
            TimerGen(timeDefault.timeList[3]);
            TimerGen(timeDefault.timeList[4]);
            TimerGen(timeDefault.timeList[5]);
            TimerGen(timeDefault.timeList[9]);
            TimerGen(timeDefault.timeList[10]);
            TimerGen(timeDefault.timeList[11]);
            TimerGen(timeDefault.timeList[12]);
            TimerGen(timeDefault.timeList[13]);
            TimerGen(timeDefault.timeList[14]);
        }
    }
}