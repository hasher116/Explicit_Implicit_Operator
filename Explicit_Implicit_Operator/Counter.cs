using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Implicit_Operator
{
    class Counter
    {
        public int Seconds { get; set; }
        public static implicit operator Counter (int x)
        {
            return new Counter { Seconds = x };
        }
        public static explicit operator int (Counter counter)
        {
            return counter.Seconds;
        }
    }
}
