using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Tasks_3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Task 3. Проверка даты
            Console.WriteLine("Задание 3.\nВ этом задании осуществляется проверка того, содержится ли во введенном с клавиатуры тексте дата в формате dd-mm-yyyy.");
            Console.WriteLine("Введите текст, содержащий дату в формате dd-mm-yyyy:");
            Regex dateRegex = new Regex(@"^(0[1-9]|1\d|2[0-8]|29(?=-\d\d-(?!1[01345789]00|2[1235679]00)\d\d(?:[02468][048]|[13579][26]))|30(?!-02)|31(?=-0[13578]|-1[02]))-(0[1-9]|1[0-2])-([12]\d{3})");
            String date = Console.ReadLine();

            if (dateRegex.IsMatch(date))
            {
                Console.WriteLine("В тексте “{0}” содержится дата.", date);
            }
            else
            {
                Console.WriteLine("В тексте “{0}” не содержится дата.", date);
            }
            Console.ReadKey();
             

            // Task 4. Проверка HTML.
            Console.WriteLine();
            Console.WriteLine("Задание 4.\nВ этом задании осуществляется замена всех найденных в введённой строке HTML тегов на знак “_”");
            Console.WriteLine("Введите HTML текст:");
            Regex htmlRegex = new Regex(@"<([^>]+)>");
            String html = Console.ReadLine();

            if (htmlRegex.IsMatch(html))
            {
                html = Regex.Replace(html, @"<([^>]+)>", "_");
                Console.WriteLine("Результат замены: {0}", html);
            }
            else
            {
                Console.WriteLine("HTML тэги не найдены");
            }
            Console.ReadKey();


            // Task 5. Проверка адресов эл. почты.
            Console.WriteLine();
            Console.WriteLine("Задание 5.\nВ этом задании осуществляется проверка, которая находит и выводит на экран все содержащиеся во введенной текстовой строке адреса электронной почты.");
            Console.WriteLine("Введите строку: ");
            String emailAddresses = Console.ReadLine();
            Regex emailRegex = new Regex(@"([a-z0-9][-a-z0-9_.]+)*[a-z0-9]+@([a-z0-9][a-z0-9_-])*[a-z0-9]+(\.(([a-z0-9][-a-z0-9_]+)*[a-z0-9]+))*\.[a-z]{2,6}");

            if (emailRegex.IsMatch(emailAddresses))
            {
                foreach (Match match in emailRegex.Matches(emailAddresses))
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("Не удалось найти адреса электронной почты.");
            }
            Console.ReadKey();
          

            // Task 6. Проверка аннотации чисел.
            Console.WriteLine();
            Console.WriteLine("Задание 6.\nВ этом задании осуществляется проверка текстовой строки на соответствие имеющегося в ней текста формату вещественного числа и выводит, в каком формате оно записано:");
            Console.WriteLine("Введите число: ");
            String inputDigits = Console.ReadLine();
            Regex scienceDigitRegex = new Regex(@"^([-+]*[0-9]+(\.[0-9]+)*[eE][+-]*[0-9]+)$");
            Regex simpleDigit = new Regex(@"\d");

            // Сначала проверяем, число ли это.
            if (simpleDigit.IsMatch(inputDigits))
            {
                if (scienceDigitRegex.IsMatch(inputDigits))
                {
                    Console.WriteLine("Это число в научной аннотации.");
                }
                else
                {
                    Console.WriteLine("Это число в обычной аннотации.");
                }
            }
            else
            {
                Console.WriteLine("Это не число");
            }
            Console.ReadKey();
          

            // Task 7. Проверка времени.
            Console.WriteLine();
            Console.WriteLine("Задание 7.\nВ этом задании осуществляется проверка того, сколько раз в тексте встречается время.");
            Console.WriteLine("Введите текст: ");
            String time = Console.ReadLine();
            Regex timeRegex = new Regex(@"(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]");
            MatchCollection matches = timeRegex.Matches(time);

            if (matches.Count > 0)
            {
                Console.WriteLine("Время в тексте присутствует {0} раз.", matches.Count);
            }
            else
            {
                Console.WriteLine("Время в тексте не присутствует.");
            }
            Console.ReadKey();
          

            // Task 8. Cравнительный анализ скорости работы классов String и StringBuilder для операции сложения строк.
            Console.WriteLine();
            Console.WriteLine("Задание 8.\nВ этом задании осуществляется cравнительный анализ скорости работы классов String и StringBuilder для операции сложения строк.");
            Console.WriteLine("Замеры будут осуществляться на наборах из 10, 1000 и 10000 строк");

            // Массив количества прогонов.
            int[] testSets = { 10, 1000, 10000 };

            // Количество символов в добавляемой строке.
            const int sourceStringLenght = 30;

            // Добавляемая строка.
            string sourceString = new String('T', sourceStringLenght);

            String testString = "";
            StringBuilder testStringBuilder = new StringBuilder();
            DateTime startTime, endTime;

            foreach (int set in testSets)
            {
                Console.WriteLine("Набор из {0} строк.", set);

                // String.
                startTime = DateTime.Now;
                for (int i = 0; i <= set; i++)
                {
                    testString += sourceString;
                }
                endTime = DateTime.Now;
                Console.WriteLine("String: {0} seconds", (endTime - startTime).TotalSeconds);

                // StringBuilder.
                startTime = DateTime.Now;
                for (int i = 0; i <= set; i++)
                {
                    testStringBuilder.Append(sourceString);
                }
                endTime = DateTime.Now;
                Console.WriteLine("StringBuilder: {0} seconds", (endTime - startTime).TotalSeconds);
                Console.WriteLine(); 
            }
            Console.ReadKey();
        }
    }
}
