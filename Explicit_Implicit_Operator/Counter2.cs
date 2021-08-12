using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Implicit_Operator
{
    class Counter2
    {
        public int Seconds { get; set; }
        public static implicit operator Counter2(int x)
        {
            return new Counter2 { Seconds = x };
        }
        public static explicit operator int(Counter2 counter)
        {
            return counter.Seconds;
        }
        public static explicit operator Counter2(Timer timer)
        {
            int x = timer.Hours * 60 * 60;
            int y = timer.Minutes * 60;
            int z = timer.Seconds;
            int result = x + y + z;
            return result;
        }
        public static explicit operator Timer(Counter2 counter)
        {
            int h = counter.Seconds / 3600;
            int m = (counter.Seconds % 3600) / 60;
            int s = counter.Seconds % 60;
            return new Timer
            {
                Hours = h,
                Minutes = m,
                Seconds = s
            };
        }
    }
}
