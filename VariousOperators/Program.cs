﻿using System ;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;


    namespace VariousOperators
    {
      
        class Program
        {
           
        static void Main (string[] args)
            {
                Console.WriteLine("Insere número inteiro-não negativo:");
                string inteiroStr = Console.ReadLine();
                byte n = byte.Parse(inteiroStr);
                int x = n/2;
                int y = n << 3;
                int z = n ^ 6;
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(z);
                if (n > 10)
                {
                    Console.WriteLine("True");
                }
                else
                {   
                    Console.WriteLine("False");
                }




            }
        }
    }