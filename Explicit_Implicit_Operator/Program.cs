using System;

namespace Explicit_Implicit_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 = new Counter(); // 1 задание. Класс Counter
            counter1.Seconds = 24;
            int x = (int)counter1; // явное преобразование из Counter в int
            int y = 35;
            Counter counter11 = y; // неявное преобразование из int в Counter
            Console.WriteLine(counter11.Seconds);

            Counter2 counter2 = new Counter2(); // 2 задание. Класс Counter2 и Timer
            counter2.Seconds = 15876;
            int z = (int) counter2; // явное преобразование из Counter2 в int
            Console.WriteLine(z);
            int intCount = 1256;
            Counter2 count = intCount; // неявное преобразование из int в Counter2
            Console.WriteLine(count.Seconds);
            Timer timer = new Timer();
            timer = (Timer) counter2; // явное преобразование из Counter в Timer
            Console.WriteLine($"{timer.Hours}:{timer.Minutes}:{timer.Seconds}");
            Timer timer2 = new Timer();
            timer2.Hours = 5;
            timer2.Minutes = 55;
            timer2.Seconds = 46;
            Counter2 counter21 = (Counter2) timer2; // явное преобразование из Timer в Counter2
            Console.WriteLine($"{counter21.Seconds}");

        }
    }
}
