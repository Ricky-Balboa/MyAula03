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

            for (i = 1; i <= n; i++)//executar enquanto i é menor que numero de andares
            {
                for (spaces = 1; spaces <= n - i; spaces++)//executar enquanto numero de espaçoe é menor ou igual a andares menos numero da "ronda"
                    Console.Write(" ");
                for (spaces = 1; spaces <= 2* i - 1; spaces++)//executar enquanto o numero de espaços é menor ou igual a 2*i -1
                    Console.Write("*");
                    Console.Write("\n");
            }
            Console.ReadKey();
            
        }
    }
}
