using System;

namespace FornavnEfternavnS1.Input.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et bogstav");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine($"Du tastede {input}");
        }
    }
}
