using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Task2
{
    class Program
    {
        // Application consist from 3 classes:
        // 1. ConfigRead - reading data from app.congig and represents it.
        // 2. FileHelper - reads and writes data to files
        // 3. Program - main class.

        // Global counters
        public static int intCounter;
        public static int stringCounter;

        static void Main(string[] args)
        {
            Console.WriteLine("Запускаемся...");

            FileHelper FileHelper = new FileHelper();

            // Subscribe to ReadCompleted event.
            FileHelper.ReadCompleted += ParseData;

            // Reading data from file.
            FileHelper.ReadFromFile(ConfigReader.InputFilePath);

            // Writing output data to file.
            FileHelper.WriteToFile(ConfigReader.OutputFilePath, intCounter, stringCounter);

            Console.WriteLine();
            Console.WriteLine("Результат:");
            Console.WriteLine("intCounter is {0}", intCounter);
            Console.WriteLine("stringCounter is {0}", stringCounter);

            Console.ReadKey();
        }

        public static void ParseData(object sender, ReadCompletedEventArgs e) {

            Console.WriteLine("Начинаем парсить полученные данные...");

            // Reading separator from Config Reader.
            String [] data = e.result.Split(ConfigReader.Separator);

            // Checking type of element (using TryParse) and invoke universal AddValue method using delegate.
            foreach (string element in data) 
            {
                int number;
                if (Int32.TryParse(element, out number))
                {
                    AddValue(element, SumInt);
                }
                else {
                    AddValue(element, SumString);
                }
            }

            // Makeing userfrendly output :)
            Console.WriteLine("Парсинг полученных данных завершён.");

        }

        public delegate void Sum(String element);

        public static void SumInt(String element)
        {
            int count;
            if (Int32.TryParse(element, out count))
            {
                if (count != 0)
                {
                    intCounter += count;
                }
            }
        }

        public static void SumString(String element)
        {
            if (!element.Equals(""))
            {
                stringCounter += element.Length;
            }
        }

        public static void AddValue (String element, Sum sum) {
            sum(element);
        }





    }
}
