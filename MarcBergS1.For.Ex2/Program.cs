using System;

namespace MarcBergS1.For.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while (!done)
            {

                Console.WriteLine("Indtast et tal mellem 1-20");
                string input = Console.ReadLine();
                if (input == "exit")
                {
                    done = true;
                    Console.WriteLine("farvel");
                }
                else
                {
                    int multiplicationTable = Int32.Parse(input);
                    Console.WriteLine("Indtast et tal mellem 10-20");
                    string input2 = Console.ReadLine();
                    int valueCount = Int32.Parse(input2);
                    for (int i = 1; i <= valueCount; i++)
                    {
                        Console.WriteLine(multiplicationTable * i);
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
