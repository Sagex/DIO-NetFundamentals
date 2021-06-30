using System;

namespace Desafio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;
            string[] t = Console.ReadLine().Split();
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);

            x = a + b;

            Console.WriteLine(String.Format("X = {0}", x));
        }
    }
}
