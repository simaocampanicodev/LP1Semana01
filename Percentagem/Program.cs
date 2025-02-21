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

            float number1 = float.Parse(input1);
            float number2 = float.Parse(input2);
            float number3 = float.Parse(input3);
            float number4 = float.Parse(input4);

            Console.WriteLine($"{number1,8:p2}");
            Console.WriteLine($"{number2,8:p2}");
            Console.WriteLine($"{number3,8:p2}");
            Console.WriteLine($"{number4,8:p2}");
        }
    }
}
