using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            short power = 7;
            int xp_needed = 1000000;
            long gold = 10000000000L;
            Console.WriteLine($"Power: {power}, xp: {xp_needed}, gold: {gold}");

            char c1 = '\u2764', c2 = '\u2766', c3 = '\u5350';
            Console.WriteLine($"\nChars: {c1} {c2} {c3}");

            double money = 10.5d;
            float chance_perc = 0.50f;
            Console.WriteLine($"\n\nMoney: {money}, chance: {chance_perc}");

            bool true_power = true;
            bool false_power = false;
            Console.WriteLine($"Power: {true_power} or {false_power}");
        }
    }
}
