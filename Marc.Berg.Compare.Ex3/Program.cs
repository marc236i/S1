using System;

namespace Marc.Berg.Compare.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = DateTime.Now.Year;
            Console.WriteLine("Indtast det år du er født i, efterfult af enter");
            string birthInput = Console.ReadLine();
            int birthNumber = Int32.Parse(birthInput);
            int age = year - birthNumber;
            bool beer = age > 16;
            bool liquor = age > 18;
            Console.WriteLine($"Du er {age} år");
            Console.WriteLine($"Køb af øl {beer}");
            Console.WriteLine($"Køb af spiritus {liquor}");

        }
    }
}
