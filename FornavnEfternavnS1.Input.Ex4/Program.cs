using System;

namespace FornavnEfternavnS1.Input.Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv din alder, efterfulgt af enter");
            string ageInput = Console.ReadLine();
            int ageNumber = Int32.Parse(ageInput);
            Console.WriteLine($"Utroligt! Er du virkelig kun {ageNumber} år??");
        }
    }
}
