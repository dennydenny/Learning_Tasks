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
                int count = GetRowCount();
                DrawLines(count);
                Console.ReadKey();
        }          

        private static int GetRowCount() {
            Console.WriteLine("Приложение выводит на экран N кол-во строк, состоящих из 'звёздочек'");
            Console.WriteLine();
            Console.Write("Сколько строк вы бы хотели увидеть? ");
            String input_count = Console.ReadLine();

            int count;
            if (Int32.TryParse(input_count, out count))
            {
                if (count <=0 )
                {
                    Console.WriteLine("Вы ввели некорректное значение. Значение должно быть больше, чем 0");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Возникла ошибка при преобразовании введённого значения");
                Console.WriteLine();
            }

            return count;
        }

        private static void DrawLines(int count) {
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < count; i++) 
            {
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
