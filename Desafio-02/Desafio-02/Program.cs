using System;

namespace Desafio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            for(int i = 1; i <= qtdTeste; i++)
            {
                string[] valores = Console.ReadLine().Split(" ");
                v1 = valores[0];
                v2 = valores[1];
                
                if(valores[0] == valores[1])
                {
                    Console.WriteLine($"Caso #{i}: De novo!");
                }
                else
                {
                    if (valores[0] == "tesoura" && valores[1] == "papel" || valores[0] == "tesoura" && valores[1] == "lagarto" || valores[0] == "papel" && valores[1] == "pedra" ||
                        valores[0] == "papel" && valores[1] == "Spock" || valores[0] == "pedra" && valores[1] == "lagarto" || valores[0] == "pedra" && valores[1] == "tesoura" ||
                        valores[0] == "lagarto" && valores[1] == "Spock" || valores[0] == "lagarto" && valores[1] == "papel" || valores[0] == "Spock" && valores[1] == "tesoura" ||
                        valores[0] == "Spock" && valores[1] == "pedra")
                    {
                        Console.WriteLine($"Caso #{i}: Bazinga!");
                    }
                    else
                    {
                        Console.WriteLine($"Caso #{i}: Raj trapaceou!");
                    }
                }
            }
        }
    }
}
