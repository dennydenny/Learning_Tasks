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
            Console.WriteLine("Приложение удваивает в первой введенной строке все символы, принадлежащие второй введенной строке.");

            Console.Write("Введите первую строку: ");
            String First = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            String Second = Console.ReadLine();

            try
            {
                StringHelper sh = new StringHelper(First, Second);
                Console.WriteLine("Результирующая строка: {0}", sh.MergedString);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Возникла ошибка {0}", e.Message);
            }
            Console.ReadKey();
        }
    }

    public class StringHelper
    {
        /// <summary>
        /// Первая строка (её символы будут удваиваться на основе совпадения со второй строкой).
        /// </summary>
        public String FirstString { get; private set; }

        /// <summary>
        /// Вторая строка (на основе ей будет осуществляться поиск в первой строке).
        /// </summary>
        public String SecondString { get; private set; }

        /// <summary>
        /// Смешанная строка, которая получается путём удваивания символов первой строки, которые входят во вторую.
        /// </summary>
        public String MergedString { get {return this.MergeStrings();}}

        /// <summary>
        /// Инициирует экземпляр StringHelper.
        /// </summary>
        /// <param name="first">Первая строка (её символы будут удваиваться на основе совпадения со второй строкой).</param>
        /// <param name="second">Вторая строка (на основе ей будет осуществляться поиск в первой строке).</param>
        public StringHelper(String first, String second)
        {
            if (String.IsNullOrEmpty(first))
            {
                throw new ArgumentNullException("Первая строка");
            }
            else if (String.IsNullOrEmpty(second))
            {
                throw new ArgumentNullException("Вторая строка");
            }
            else
            {
                this.FirstString = first;
                this.SecondString = second;
            }
        }

        /// <summary>
        /// Метод осуществляет поиск символов второй строки в первой строке и удваивает найденные символы.
        /// </summary>
        /// <returns>Строка, в которой удвоены символы, которые присутствуют в первой и во второй строках.</returns>
        private String MergeStrings()
        {
            StringBuilder sb = new StringBuilder();

            foreach (char ch in FirstString)
                if (!SecondString.Contains(ch))
                    sb.Append(ch);
                else
                {
                    sb.Append(ch);
                    sb.Append(ch);
                }
            return sb.ToString();
        }
    
    }
}
