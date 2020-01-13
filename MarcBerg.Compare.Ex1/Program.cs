using System;

namespace MarcBerg.Compare.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"17 < 10" + (17 < 10));
            Console.WriteLine($"20 > 20" + (20 > 20));
            Console.WriteLine($"17 <= 10" + (17 <= 10));
            Console.WriteLine($"50! = 10 * 5" + (50 != 10 * 5));
            Console.WriteLine($"27 - 0,15 >= 28 - 1,15" + (27 - 0, 15 >= 28 - 1, 15));
            Console.WriteLine($"5⋅3==15" + (5 * 3 == 15));
            Console.WriteLine($"5/5==1" + (5 / 5 == 1));
        }
    }
}
