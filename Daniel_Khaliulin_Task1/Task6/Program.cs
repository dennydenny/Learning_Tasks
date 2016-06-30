using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task6
{
    class Program
    {

        static void Main(string[] args)
        {
                StringBuilder style = new StringBuilder().Clear();
                Console.WriteLine("Приложение позволяет назначать или удалять настройки выделения текстовой подписи.");

                while (1 == 1)
                {
                    Console.WriteLine("Параметры надписи: {0}", ShowStyle(ref style));
                    Console.WriteLine("Введите: \r\n 1: bold \r\n 2: italic \r\n 3: underline");
                    String input = Console.ReadLine();

                    int selected_style;
                    if (Int32.TryParse(input, out selected_style))
                    {
                        if (selected_style <= 3 && selected_style > 0)
                        {
                            SetStyle(input, ref style);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Отсутствует параметр. Введите значение от 1 до 3");
                        }
                    }
                    else {
                        Console.WriteLine();
                        Console.WriteLine("Введите значение от 1 до 3");
                    }
                    Console.WriteLine();
                }
        }

        public static String ShowStyle(ref StringBuilder style)
        {
            StringBuilder sb = new StringBuilder();

            if (style.Length == 0) 
            {
                return "None";
            }

            if (style.ToString().IndexOf("1") != -1)
            {
                sb.Append(" Bold");
            }

            if (style.ToString().IndexOf("2") != -1)
            {
                sb.Append(" Italic");
            }

            if (style.ToString().IndexOf("3") != -1)
            {
                sb.Append(" Underline");
            }

            return sb.ToString();
        }

        public static void SetStyle(string input, ref StringBuilder style) {

            int start = style.ToString().IndexOf(input);

            if (start == -1)
            {
                style.Append(input);
            }
            else {
                int lenght = input.Length;
                style.Remove(start, lenght);
            }    
        }
    }
}
