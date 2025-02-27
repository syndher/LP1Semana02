﻿using System ;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;


    namespace SmoothOperator
    {
      
        class Program
        {
           
        static void Main (string[] args)
            {
                Console.WriteLine("Insere número inteiro:");
                string inteiroStr = Console.ReadLine();
                sbyte inteiro = sbyte.Parse(inteiroStr);
                inteiro = --inteiro;
                Console.WriteLine(inteiro);
                inteiro = ++inteiro;
                Console.WriteLine(inteiro);


            }
        }
    }