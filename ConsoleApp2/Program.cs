// See https://aka.ms/new-console-template for more information
using System;

namespace BasicOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número:");
            double num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            double num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
            Console.WriteLine("El resultado de la resta es: " + (num1 - num2));
            Console.WriteLine("El resultado de la multiplicación es: " + (num1 * num2));
            Console.WriteLine("El resultado de la división es: " + (num1 / num2));
            Console.WriteLine("El resultado del residuo es: " + (num1 % num2));
            Console.WriteLine("El valor absoluto del primer número es: " + Math.Abs(num1));
            Console.WriteLine("El resultado de la potencia es: " + Math.Pow(num1, num2));
            Console.WriteLine("La raíz cuadrada del primer número es: " + Math.Sqrt(num1));
            Console.WriteLine("El seno del primer número es: " + Math.Sin(num1 * Math.PI / 180));
            Console.WriteLine("El coseno del primer número es: " + Math.Cos(num1));
            Console.WriteLine("El número máximo es: " + Math.Max(num1, num2));
            Console.WriteLine("El número mínimo es: " + Math.Min(num1, num2));
            Console.WriteLine("La parte entera del primer número es: " + (int)num1);
            Console.WriteLine("El redondeo del primer número es: " + Math.Round(num1));

            Console.ReadLine();
        }
    }
}
