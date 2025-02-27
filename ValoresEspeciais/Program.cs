﻿using System ;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

    namespace ValoresEspeciais
    {
      
        class Program
        {
           
        static void Main (string[] args)
            {
                long lM = long.MaxValue;
                long lm = long.MinValue;
                byte bM = byte.MaxValue;
                byte bm = byte.MinValue;
                double dM = double.MaxValue;
                double dm = double.MinValue;
                sbyte sbM = sbyte.MaxValue;
                sbyte sbm = sbyte.MinValue;
                ulong ulM = ulong.MaxValue;
                ulong ulm = ulong.MinValue;
                float fM = float.MaxValue;
                float fm = float.MinValue;
                short sM = short.MaxValue;
                short sm = short.MinValue;
                ushort usM = ushort.MaxValue;
                ushort usm = ushort.MinValue;
                int iM = int.MaxValue;
                int im = int.MinValue;
                uint uiM = uint.MaxValue;
                uint uim = uint.MinValue;
                char cM = char.MaxValue;
                char cm = char.MinValue;
                string everymaxmin = $"{lM}, {lm}, {bM}, {lm}, {bm}, {dM}, {dm}, {sbM}, {sbm}, {ulM}, {ulm}, {fM}, {fm}, {sM}, {sm}, {usM}, {usm}, {iM}, {im}, {uiM}, {uim}, {cM}, {cm}";
                Console.WriteLine(everymaxmin);

                double x = double.PositiveInfinity;
                double y = double.NegativeInfinity;
                float z = float.NaN;
                string symbols = $"{x}, {y}, {z}";
                Console.WriteLine(symbols);

                uint ui = uint.MaxValue;
                Console.WriteLine(ui + 1);

                Console.WriteLine(fM + fM); //Overflow by causing infinity
                Console.WriteLine(fM + 1);  //Overflow by a non-change in the number after an addition

                float f2 = float.MaxValue;

                Console.WriteLine(fM == f2 + 0.00001f); //Underflow by a non-change in the number addition, resulting in fM == f2, which counts as True










            }
        }
    }