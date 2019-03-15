using System;

namespace PrecorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Defina a frase que deseja trabalhar");
            string s = Console.ReadLine();
            Console.WriteLine("Escolha uma Letra para omitir");
            string s2 = Console.ReadLine();
            char C = Convert.ToChar(s2);


            foreach (char c in s)
            {
                if (C != c)
                    Console.Write(c);
                else
                    Console.Write("");
            }

            Console.ReadKey();
        }
    }
}
