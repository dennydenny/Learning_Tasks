using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение описывает треугольник, со сторонами a, b, c и позволяет осуществить расчет его площади и периметра.");

            Triangle tri = new Triangle();

            double a;

            // Making loop while side of triangle have no value.
            while (tri.a == 0)
            {
                Console.WriteLine("Пожалуйста, укажите длину стороны а");

                // Checking is input have digit type. If so, we are assign value to side of trianle.
                if (Double.TryParse(Console.ReadLine(), out a))
                {
                    if (a > 0)
                    {
                        tri.a = a;
                    }
                    else 
                    {
                        Console.WriteLine("Сторона треугольника должна быть больше нуля.");
                    } 
                }
                else
                {
                    Console.WriteLine("Введите числовое значение стороны треугольника");
                }
            }

            double b;
            while (tri.b == 0)
            {
                Console.WriteLine("Пожалуйста, укажите длину стороны b");
                if (Double.TryParse(Console.ReadLine(), out b))
                {
                    if (b > 0)
                    {
                        tri.b = b;
                    }
                    else
                    {
                        Console.WriteLine("Сторона треугольника должна быть больше нуля.");
                    }
                }
                else
                {
                    Console.WriteLine("Введите числовое значение стороны треугольника");
                }
            }

            double c;
            while (tri.c == 0)
            {
                Console.WriteLine("Пожалуйста, укажите длину стороны c");
                if (Double.TryParse(Console.ReadLine(), out c))
                {
                    if (c > 0)
                    {
                        tri.c = c;
                    }
                    else
                    {
                        Console.WriteLine("Сторона треугольника должна быть больше нуля.");
                    }
                }
                else
                {
                    Console.WriteLine("Введите числовое значение стороны треугольника");
                }
            }

            // Checking Triangle inequality (https://en.wikipedia.org/wiki/Triangle_inequality). 
            // Each side of the triangle should be less than the sum of the other two sides.
            if (tri.isSidesCorrect)
            {
                Console.WriteLine("Длина сторон треугольника - a - {0}, b - {1}, c - {2}", tri.a, tri.b, tri.c);
                Console.WriteLine();
                Console.WriteLine("Периметр треугольника - {0}", tri.P);
                Console.WriteLine("Площадь треугольника - {0}", tri.S);
            }
            else {
                Console.WriteLine("Указанные длины сторон не выполняют неравенства треугольника (каждая длина должна быть меньше, чем сумма двух других длин)");
            }
            Console.ReadKey();
        }
    }
}
