using System;

namespace Desafio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeatCheck = true;
            bool runCalc = true;
            double media = 0.0;
            double nota;
            int count;

            count = 0;
            nota = 0.0;
            while (runCalc != false)
            {
                if(count <= 1)
                {
                    nota = double.Parse(Console.ReadLine());
                }                
                if (nota < 0 || nota > 10.0)
                {
                    Console.WriteLine("nota invalida");
                }
                else if (count <= 1)
                {
                    count++;
                    media += nota;
                    
                }
                else if (count == 2)
                {

                    media /= 2;
                    Console.Write("media = ");
                    Console.WriteLine(media.ToString("N2"));

                    while (repeatCheck != false)
                    {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        double res = double.Parse(Console.ReadLine());

                        
                        if (res == 1.0)
                        {
                            repeatCheck = false;
                            count = 0;
                            media = 0.0;
                        }
                        else if (res == 2.0)
                        {
                            repeatCheck = false;
                            runCalc = false;
                        }
                    }
                    repeatCheck = true;
                }
            }
        }
    }
}
//input = Console.ReadLine();
//success = Int32.TryParse(input, out number);

//if (success == false || (number < 0 || number > 10))