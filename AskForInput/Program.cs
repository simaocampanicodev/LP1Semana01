using System;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            string input = Console.ReadLine();
            int number =  0;
            number = int.Parse(input);

            Console.WriteLine("Digite um número real: ");
            input = Console.ReadLine();
            float number2 = 0f;
            number2 = float.Parse(input);
        }
    }
}
