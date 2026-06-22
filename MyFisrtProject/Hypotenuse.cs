using System;
using System.Collections.Generic;
using System.Text;

namespace MyFisrtProject
{
    internal class Hypotenuse
    {
        public void CalculateHypotenuse()
        {
            Console.WriteLine("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine("The hypotenuse is: " + c);
        }
    }
}