using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение выводит на экран сумму всех чисел меньше 1000, кратных 3, или 5.");
            Console.WriteLine("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();

            int sum = 0;

            for (int i = 0; i < 1000; i++) {
                if (i % 3 == 0) 
                {
                    sum += i;
                }

                if (i % 5 == 0)
                {
                    sum += i;
                }
            
            }

            Console.WriteLine("Сумма чисел = {0}", sum);
            Console.ReadKey();
        }
    }
}
