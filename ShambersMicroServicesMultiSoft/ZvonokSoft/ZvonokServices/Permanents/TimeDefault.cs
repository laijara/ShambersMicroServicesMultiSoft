using System;
using System.Collections.Generic;

namespace ShambersMicroServicesMultiSoft.ZvonokSoft.ZvonokServices
{
    internal class TimeDefault
    {
        public readonly Dictionary<int, TimeSpan> timeListStart = new Dictionary<int, TimeSpan>()
        {
            {1, new TimeSpan(9, 00, 00)},
            {2, new TimeSpan(10, 40, 00)},
            {3, new TimeSpan(12, 30, 00)},
            {4, new TimeSpan(14, 05, 00)},
            {5, new TimeSpan(15, 40, 00)},
            {6, new TimeSpan(17, 15, 00)},
            {7, new TimeSpan(0, 00, 00)},
            {8, new TimeSpan(0, 00, 00)},
            {9, new TimeSpan(0, 00, 00)},
        };

        public readonly Dictionary<int, TimeSpan> timeListEnd = new Dictionary<int, TimeSpan>()
        {
            {1, new TimeSpan(10, 30, 00)},
            {2, new TimeSpan(12, 10, 00)},
            {3, new TimeSpan(14, 00, 00)},
            {4, new TimeSpan(15, 35, 00)},
            {5, new TimeSpan(17, 10, 00)},
            {6, new TimeSpan(18, 45, 00)},
            {7, new TimeSpan(0, 00, 00)},
            {8, new TimeSpan(0, 00, 00)},
            {9, new TimeSpan(0, 00, 00)}
        };
    }
}