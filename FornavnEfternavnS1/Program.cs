using System;

namespace FornavnEfternavnS1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv dit navn, efterfulgt af enter");
            string input = Console.ReadLine();
            Console.WriteLine($"Hej {input} Godt at se dig!");
        }
    }
}
