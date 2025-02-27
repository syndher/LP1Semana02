﻿using System ;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

    namespace Cilindro
    {
      
        class Program
        {
           
        static void Main (string[] args)
            {
                Console.WriteLine("Insere a altura do cilindro:");  //Pede uma altura ao utilizador e converte-a para double
                string altura = Console.ReadLine();
                double h = double.Parse(altura);

                Console.WriteLine("Insere o raio do cilindro:");    //Pede um raio ao utilizador e converte-o em float
                string raio = Console.ReadLine();
                float r = float.Parse(raio);

                float r2 = MathF.Pow(r, 2);     //Eleva o raio a 2 e converte-o para float

                double x = MathF.PI;    //Converte Pi para double
             
                double v = x * r2 * h;  //Formula do Volume do Cilindro

                string volume = $"{v:f3}";  //Formata o valor em apenas 3 casas decimais e converte em string
             
                Console.WriteLine(volume);  //Imprime a string obtida do volume

                




            }
        }
    }