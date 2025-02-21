using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            
            Console.WriteLine("Insere 4 números reais entre 0 e 1:");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();

            double number1 = double.Parse(input1);
            double number2 = double.Parse(input2);
            double number3 = double.Parse(input3);
            double number4 = double.Parse(input4);

            Console.WriteLine($"{number1,7:p2}");
            Console.WriteLine($"{number2,7:p2}");
            Console.WriteLine($"{number3,7:p2}");
            Console.WriteLine($"{number4,7:p2}");
        }
    }
}
