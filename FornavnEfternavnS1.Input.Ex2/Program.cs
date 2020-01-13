using System;

namespace FornavnEfternavnS1.Input.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv dit navn, efterfulgt af enter");
            string navnInput = Console.ReadLine();
            Console.WriteLine("Skriv din alder, efterfulgt af enter");
            string ageInput = Console.ReadLine();
            int ageNumber = Int32.Parse(ageInput);
            Console.WriteLine("Skriv din højde, efterfulgt af enter");
            string heightInput = Console.ReadLine();
            //double heightNumber = Double.Parse(heightInput);
            double.TryParse(heightInput, out double heightNumber);
            Console.WriteLine($"Hej {navnInput} du er {ageNumber}år og din højde er {heightNumber}");
        }
    }
}
