using System;
using System.Globalization;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Digite um número inteiro: ");
            string input = Console.ReadLine();
            int number =  0;
            number = int.Parse(input);

            Console.WriteLine("Digite um número real: ");
            input = Console.ReadLine();
            float number2 = 0f;
            number2 = float.Parse(input);

            Console.WriteLine($"{number} plus {number2} is equal to {number+number2}.");
        }
    }
}
