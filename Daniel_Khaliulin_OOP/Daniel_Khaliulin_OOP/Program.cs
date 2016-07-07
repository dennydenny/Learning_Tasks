using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение демонстрирует работу класса Round, который имеет координата центра (X, Y), радиус, длину и площадь окружности.");

            Round round = new Round();
            Console.WriteLine("Пожалуйста, введите координату Х центра окружности:");
            round.X = Double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите координату Y центра окружности:");
            round.Y = Double.Parse(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите радиус окружности:");
            round.R = Double.Parse(Console.ReadLine());

            Console.WriteLine("Координаты центра окружности - ({0}; {1})", round.X, round.Y);
            Console.WriteLine("Радиус окружности - {0}", round.R);
            Console.WriteLine();
            Console.WriteLine("Длина описанной окружности - {0}", round.Lenght);
            Console.WriteLine("Площадь окружности - {0}", round.S);


            Console.ReadKey();
        }
    }
}
