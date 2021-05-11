using System;
using System.Collections.Generic;

namespace Desafio_05
{
    class Program
    {
        static void Main(string[] args)
        {


            List<List<string>> novaList = new();

            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());

            for (int i = 0; i != totalDeCasosDeTeste; i++)
            {
                List<string> listCompra = new List<string>();
                string[] stringTemp = Console.ReadLine().Split(" ");
                Array.Sort(stringTemp);

                listCompra.Add(stringTemp[0]);


                for (int t = 0; t < stringTemp.Length; t++)
                {
                    bool tf = true;
                    for (int d = 0; d < listCompra.Count; d++)
                    {
                        if (listCompra[d].ToString() == stringTemp[t].ToString())
                        {
                            tf = false;
                            break;
                        }
                    }
                    if (tf)
                    {
                        listCompra.Add(stringTemp[t]);
                    }
                }

                novaList.Add(listCompra);
            }

            foreach (List<string> x in novaList)
            {
                Console.WriteLine(String.Join(" ", x));
            }




        }
    }
}
