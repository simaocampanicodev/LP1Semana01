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
        }
    }
}
