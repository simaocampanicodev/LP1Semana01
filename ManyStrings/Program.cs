using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;
            Console.WriteLine($"2 casas: {xx:f2}");
            Console.WriteLine($"Percentagem com uma casa decimal: {xx:p1}");
            Console.WriteLine($"Hexadecimal: {ii:x}");
            Console.WriteLine($"Moeda: {ii:c}");

            string welcomeMessage = "\nHello my friend:";
            string playerName = "Txger";
            char c1 = '\u26A1';
            string phrase = $"{welcomeMessage}\n Player: {playerName}\n Do your best\t{c1}";
            Console.WriteLine(phrase);

            int money = 10;
            int moneyNeeded = 100;
            Console.WriteLine($"\nYou have {money} dollars. You need ({moneyNeeded - money}) more.");

            double amount = 1.111111;
            Console.WriteLine($"2 decimal places: {amount:f2}");

            int x = 3;
            int y = 7;
            Console.WriteLine($"{x} + {y} is equal to {x + y}.");
            Console.WriteLine($"The value of x is {x} and the value of y is {y}.");
        }
    }
}
