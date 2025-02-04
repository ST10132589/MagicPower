using System;

namespace MagicPower
{
    public class Program
    {
        static void Main(string[] args)
        {
            long power = long.Parse(Console.ReadLine());
            Console.WriteLine(IsMagicalPotion(power));
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }

        public static string IsMagicalPotion(long power)
        {
            long cubeRoot = (long)Math.Round(Math.Pow(power, 1.0 / 3.0));
            if (cubeRoot * cubeRoot * cubeRoot == power)
            {
                return "YES";
            }
            return "NO";
        }
    }
}