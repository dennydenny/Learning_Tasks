using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace Daniel_Khaliulin_Task2
{
    class FileHelper
    {
        // Events
        public event EventHandler<ReadCompletedEventArgs> ReadCompleted;
        public event EventHandler WriteCompleted;

        public void WriteToFile(string filepath, int intCounter, int stringCounter)
        {
            Console.WriteLine("Записываем результат в файл {0}", filepath);

            if (!filepath.Equals(""))
            {
                if (!File.Exists(filepath))
                {
                    File.Create(filepath);
                }

                File.AppendAllText(filepath, String.Format("Арифметическая Сумма = {0} Число символов = {1}", intCounter, stringCounter));
                OnWriteCompleted();
            }
            else {
                Console.WriteLine("Путь к выходному файлу не может быть пустым.");
            }

            Console.WriteLine("Запись результатов в файл завершена");
        }

        public void ReadFromFile(string filepath)
        {
            Console.WriteLine("Читаем из файла {0}", filepath);
            try
            {
                // Check is filepath empty.
                if (!filepath.Equals(""))
                {
                    // Check is filepath exist
                    if (File.Exists(filepath))
                    {
                        String data = File.ReadAllText(filepath);
                        OnReadCompleted(new ReadCompletedEventArgs(data));
                    }

                    else
                    {
                        Console.WriteLine("Файла не существует :(. Поиск осуществлялся в " + filepath);
                    }

                }
                else
                {
                    Console.WriteLine("Путь к исходному файлу не может быть пустым.");
                }
            }
            catch (Exception e) {
                Console.WriteLine("{0} {1}", e.Message, e.StackTrace);
            }
            Console.WriteLine("Чтение из файла завершено.");
        }

        protected virtual void OnReadCompleted(ReadCompletedEventArgs e) {
            EventHandler<ReadCompletedEventArgs> temp = ReadCompleted;
            if (temp != null)
            {
                ReadCompleted(this, e);
            }        
        }

        protected virtual void OnWriteCompleted()
        {
            EventHandler temp = WriteCompleted;
            if (temp != null)
            {
                WriteCompleted(this, EventArgs.Empty);
            }
        }
    }

    class ReadCompletedEventArgs : EventArgs {
        private readonly String _result;

        public ReadCompletedEventArgs(String result) {
            _result = result;
        }

        public String result { get { return _result; } }
    }
}
