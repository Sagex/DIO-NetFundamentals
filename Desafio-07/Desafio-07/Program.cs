﻿using System;

namespace Desafio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = Console.ReadLine();
            char[] arr = v.ToCharArray();
            if (arr.Length  <= 140)
            {
                Console.WriteLine("TWEET");
            }
            else
            {
                Console.WriteLine("MUTE");
            }
        }
    }
}
