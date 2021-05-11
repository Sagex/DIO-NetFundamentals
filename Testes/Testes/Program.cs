using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {

            bool check = true;
            string pass;

            while (!String.IsNullOrEmpty(pass = Console.ReadLine()))
            {
                //Regex rgx = new Regex(@"^(?=.[a-z])(?=.[A-Z])(?=.*\d)[a-zA-Z\d]{6,32}$");
                Regex rgx = new Regex(@"^(?!.*[\s])(?!.*[!@#$%¨&*()=+*/\\?°^~´`{}'<>,.;:])(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,32}$");




                if (rgx.IsMatch(pass))
                {
                    Console.WriteLine("Senha valida");

                }
                else
                {
                    Console.WriteLine("Senha invalida");


                }
            }
        }
    }
}
