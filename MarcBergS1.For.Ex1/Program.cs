using System;

namespace MarcBergS1.For.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast en start værdi");
            string from = Console.ReadLine();
            int fromInput = Int32.Parse(from);
            Console.WriteLine("Indtast en slut værdi");
            string to = Console.ReadLine();
            int toInput = Int32.Parse(to);

            for (int i =fromInput; i <= toInput; i++)
            {
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
