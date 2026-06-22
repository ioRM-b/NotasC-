using System;
using System.Collections.Generic;
using System.Text;

namespace MyFisrtProject
{
    internal class Class1
    {
        public void GeneradorDeNumeroRandom()
        {
            Random random = new Random();
           // int num = random.Next(1, 7) + 100;
           double num = random.NextDouble();
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}