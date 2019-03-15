using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 2;
            int c = a++ + b++;
            int d = 70;
            int e = 39;
            int f = ++d + ++e;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("a++ + b++ = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("e = " + e);
            Console.WriteLine("++d + ++e = " + f);
            Console.ReadKey();
           
        }
    }
}
