using System;

namespace Desafio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dados = Console.ReadLine().Split(" ");
            int i = int.Parse(dados[0]);
            int ii = int.Parse(dados[1]);
            Console.WriteLine($"{(double)i / (double)ii :F2}");
        }
    }
}
