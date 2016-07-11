using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение вычеркивает каждого второго человека (от 1 до N), пока не останется один.");
            int _n = 0;

            // Print N-request until n will came good.
            while (_n <= 0)
            {
                Console.WriteLine("Введите N: ");
                String N = Console.ReadLine();

                if (Int32.TryParse(N, out _n))
                {
                    if (_n <= 0)
                    {
                        Console.WriteLine("N должен быть больше нуля");
                    }
                    else 
                    {
                        // Create and fill list.
                        List<int> list = FillList(_n);

                        // 
                        while (list.Count != 1)
                        {
                            for (int k = 1; k < list.Count; k += 2)
                            {
                                    list.RemoveAt(k);
                                    Console.WriteLine("Вычёркиваем человека с номером {0}", k);
                            }
                        }
                        Console.WriteLine("Конец");
                        Console.WriteLine("Остался: ");
                        foreach (int m in list) Console.WriteLine(m);
                        Console.ReadKey();
                    }
                }
                Console.WriteLine("N должно быть числом!");
            }
        }

        /// <summary>
        /// Creates and fills List with N elements
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public static List<int> FillList(int N) {
            List<int> _list = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                _list.Add(i);
            }
            return _list;
        }
    }
}
