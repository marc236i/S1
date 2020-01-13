using System;

namespace MarcBergS1.Arrays.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            double[] price = new double[0];
            while (!done)
            {
                Console.WriteLine("Indtast antal af varer du vil sætte priser på");
                string input = Console.ReadLine();
                int number = Int32.Parse(input);
                if (number > 0 && number < 26)
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine($"{number} er ugyldig, prøv igen");
                }
                for (int i = 1; i != number; i++)
                {
                    Console.WriteLine($"Indtast en pris på varer nummer {i}");
                    string input2 = Console.ReadLine();
                    double numberInput = double.Parse(input2);
                    price[i] = numberInput;
                }
            }

            Console.ReadLine();
        }
    }
}
