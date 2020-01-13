using System;

namespace MarcBerg.Compare.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indtast din månedsløn, efterfult af enter");
            string monthlyIncomeInput = Console.ReadLine();
            double monthlyIncomeNumber = double.Parse(monthlyIncomeInput);
            Console.WriteLine($"Din årsløn er {monthlyIncomeNumber * 12}");
            double yearlyIncomeNumber = monthlyIncomeNumber * 12;
            Console.WriteLine($"Indtast prisen på det hus du vil købe, efterfult af enter");
            string housePriceInput = Console.ReadLine();
            double housePricenumber = double.Parse(housePriceInput);
            double oneFivthOfHouse = housePricenumber * 0.2;
            Console.WriteLine($"Køb af hus {yearlyIncomeNumber >= oneFivthOfHouse}");
        }
    }
}
