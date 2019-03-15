using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("com quantos andares queres a tua piramide");
            string num = Console.ReadLine();
            int n = Convert.ToInt32(num);
            int i, spaces;

            for (i = 0; i <= n; i++)
            {
                for (spaces = 1; spaces <= n - i; spaces++)
                    Console.Write(" ");
                for (spaces = 1; spaces <= 2 * i - 1; spaces++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.ReadKey();
            
        }
    }
}
