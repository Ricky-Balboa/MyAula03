using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] tabela = new double[3, 3];
            Console.WriteLine("Vamos construir uma tabela com 3linhas e 3 colunas ");

            Console.WriteLine("Insira valor para primeira linha e primeira coluna");
            string b = Console.ReadLine();
            tabela[0, 0] = Convert.ToDouble(b);
            Console.WriteLine("Insira valor para primeira linha e segunda coluna");
            string c = Console.ReadLine();
            tabela[0, 1] = Convert.ToDouble(c);
            Console.WriteLine("Insira valor para primeira linha e terceira coluna");
            string d = Console.ReadLine();
            tabela[0, 2] = Convert.ToDouble(d);
            Console.WriteLine("Insira valor para segunda linha e primeira coluna");
            string e = Console.ReadLine();
            tabela[1, 0] = Convert.ToDouble(e);
            Console.WriteLine("Insira valor para segunda linha e segunda coluna");
            string f = Console.ReadLine();
            tabela[1, 1] = Convert.ToDouble(f);
            Console.WriteLine("Insira valor para segunda linha e terceira coluna");
            string g = Console.ReadLine();
            tabela[1, 2] = Convert.ToDouble(g);
            Console.WriteLine("Insira valor para terceira linha e primeira coluna");
            string h = Console.ReadLine();
            tabela[2, 0] = Convert.ToDouble(h);
            Console.WriteLine("Insira valor para terceira linha e segunda coluna");
            string i = Console.ReadLine();
            tabela[2, 1] = Convert.ToDouble(i);
            Console.WriteLine("Insira valor para terceira linha e terceira coluna");
            string j = Console.ReadLine();
            tabela[2, 2] = Convert.ToDouble(j);

            Double Soma1 = tabela[0, 0] + tabela[0, 1] + tabela[0, 2];
            Double Soma2 = tabela[1, 0] + tabela[1, 1] + tabela[1, 2];
            Double Soma3 = tabela[2, 0] + tabela[2, 1] + tabela[2, 2];
            Double Media1 = Soma1 / 3;
            Double Media2 = Soma2 / 3;
            Double Media3 = Soma3 / 3;
            Double Total = Media1 + Media2 + Media3;
            Console.WriteLine("A Media da primeira Linha é " + Media1);
            Console.WriteLine("A Media da Segunda Linha é " + Media2);
            Console.WriteLine("A Media da Terceira Linha é " + Media3);
            Console.WriteLine("A Soma das Medias é " + Total);
            Console.ReadKey();









        }
    }
}
