using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.GetEncoding(1251);
            
            Console.WriteLine("Приложение выполняет вычисление площади прямоугольника на основе введённых значений длины и ширины.");
            Console.Write("Введите длину: ");
            String input_lenght = Console.ReadLine();

            int lenght;
            if (Int32.TryParse(input_lenght, out lenght))
            {
                if (lenght <= 0)
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                }
            }
            else {
                Console.WriteLine("Возникла ошибка при преобразовании введённого значения");
            }

            Console.Write("Введите ширину: ");
            String input_height = Console.ReadLine();
            int height;
            if (Int32.TryParse(input_height, out height))
            {
                if (height <= 0)
                {
                    Console.WriteLine("Вы ввели некорректное значение");
                }
            }
            else
            {
                Console.WriteLine("Возникла ошибка при преобразовании введённого значения");
            }

            int s = lenght * height;

            Console.WriteLine("Площадь прямоугольника равна {0}", s);
            Console.ReadKey();
        }
    }
}
