using System;

namespace MarcBergS1.Arrays.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Indtast et drenge navne");
                string input = Console.ReadLine();
                names[i] = input;
            }

            Console.WriteLine();
            Console.ReadLine();
            
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Indtast et heltal");
                string input = Console.ReadLine();
                int numberInput = Int32.Parse(input);
                numbers[i] = numberInput;
            }
            
            bool[] cars = new bool[10];
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Indtast true eller false alt efter om der er en bil på parkerings placen");
                string input = Console.ReadLine();
                bool boolInput = bool.Parse(input);
                cars[i] = boolInput;
            }
            
            double[] pointNumbers = new double[10];
            for (int i = 0; i < pointNumbers.Length; i++)
            {
                Console.WriteLine("Indtast et kommatal");
                string input = Console.ReadLine();
                double numberInput = double.Parse(input);
                pointNumbers[i] = numberInput;
            }
        }
    }
}
