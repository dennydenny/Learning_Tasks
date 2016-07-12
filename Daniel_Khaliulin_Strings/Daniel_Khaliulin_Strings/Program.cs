using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение определяет среднюю длину слова по введённой текстовой строке");
            Console.WriteLine("Пожалуйста, введите данные:");

            String sentence = Console.ReadLine();
            try
            {
                StringHelper sh = new StringHelper(sentence);
                Console.WriteLine("Средняя длина слова {0} ", sh.AverageWordLenght);
                Console.ReadKey();
            }

            catch (Exception e)
            {
                Console.WriteLine("Возникла ошибка {0}", e.Message);
                Console.ReadKey();
            }

           

    }
}
}
