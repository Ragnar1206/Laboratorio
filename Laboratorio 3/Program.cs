using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("ejercicio 1: operaciones aritméticas");

                Console.Write("Ingrese el primer número: ");
                double num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double num2 = Convert.ToInt32(Console.ReadLine());

                double suma = num1 + num2;
                double resta = num1 - num2;
                double multiplicacion = num1 * num2;
                double division = num1 / num2;
                double mod = (int)(num1 % num2);

                Console.WriteLine("{0} + {1} = {2}", num1, num2, suma);
                Console.WriteLine("{0} - {1} = {2}", num1, num2, resta);
                Console.WriteLine("{0} * {1} = {2}", num1, num2, multiplicacion);
                Console.WriteLine("{0} / {1} = {2}", num1, num2, division);            
                Console.WriteLine("{0} % {1} = {2}", num1, num2, mod);

                Console.WriteLine("ejercicio 2: operaciones booleanas");

                bool mayorQue = num1 > num2;
                bool menorQue = num1 < num2;
                bool igualdad = num1 == num2;

                Console.WriteLine("{0} > {1} = {2}", num1, num2, mayorQue);
                Console.WriteLine("{0} < {1} = {2}", num1, num2, menorQue);
                Console.WriteLine("{0} == {1} = {2}", num1, num2, igualdad);

                Console.WriteLine("ejercicio 3: Jerarquía de operaciones");

                Console.Write("Ingrese el primer número: ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el tercer número: ");
                double c = Convert.ToDouble(Console.ReadLine());

                double resultado1 = a * b + c;
                double resultado2 = a * (b + c);
                double resultado3 = a / (b * c);
                double resultado4 = 3 * a + 2 * b / (c * c);

                Console.WriteLine("{0} * {1} + {2} = {3}", a, b, c, resultado1);
                Console.WriteLine("{0} * ({1} + {2}) = {3}", a, b, c, resultado2);
                Console.WriteLine("{0} / ({1} * {2}) = {3}", a, b, c, resultado3);
                Console.WriteLine("3 * {0} + 2 * {1} / {2}² = {3}", a, b, c, resultado4);

                Console.ReadKey();
            }
    }

}


