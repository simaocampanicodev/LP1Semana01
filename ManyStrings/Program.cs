using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string welcomeMessage = "Hello my friend:";
            string playerName = "Txger";
            char c1 = '\u2623', c2 = '\u26A1';
            string phrase = $"{welcomeMessage}\n Player: {playerName}\n Do your best\t{c2}";
            Console.WriteLine(phrase);

            int money = 10;
            int moneyNeeded = 100;
            Console.WriteLine($"You have {money} dollars. You need ({moneyNeeded} - {xp}) more.");

            double amount = 1.111111;
            Console.WriteLine($"2 decimal places: {amount:f2}");
        }
    }
}
