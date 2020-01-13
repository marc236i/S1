using System;

namespace MarcBergS1.BoolAlg.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv et tal mellem 0 og 10");
            string userInput1 = Console.ReadLine();
            int numberInput1 = Int32.Parse(userInput1);
            if (numberInput1 >= 0 && numberInput1 <= 10)
            {
                Console.WriteLine("tallet er mellem 0 og 10");
            }
            Console.WriteLine("skriv et comma tal mellem 0 og 1");
            string userInput2 = Console.ReadLine();
            double numberInput2 = double.Parse(userInput2);
            if (numberInput2 >= 0 && numberInput2 <= 1)
            {
                Console.WriteLine("tallet er mellem 0 og 1");
            }
            Console.WriteLine("skriv et tal mellem -10 og 10");
            string userInput3 = Console.ReadLine();
            int numberInput3 = Int32.Parse(userInput3);
            if (numberInput3 <= 0 && numberInput3 >= -10 || numberInput3 >= 0 && numberInput3 <= 10)
            {
                Console.WriteLine("tallet er mellem -10 og 10");
            }
            Console.WriteLine("Indtast en vokal");
            string userInput4 = Console.ReadLine();
            if (userInput4 == "a" || userInput4 == "A" || userInput4 == "e" || userInput4 == "E" || userInput4 == "i" || userInput4 == "I" || userInput4 == "o" || userInput4 == "O" || userInput4 == "u" || userInput4 == "U" || userInput4 == "y" || userInput4 == "Y")
            {
                Console.WriteLine("Bogstavet er en vokal");
            }
            string userInput5 = Console.ReadLine();
            if (userInput5 == "exit"|| userInput5 == "quit")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Prøv igen");
            }
        }
    }
}
