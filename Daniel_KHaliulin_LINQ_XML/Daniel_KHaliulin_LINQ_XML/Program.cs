using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;


namespace LINQ_XML
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Приложение позволяет осуществить поиск клиентов банка и выгрузку результатов в формате XML в файл.\nЕсли какой-то из параметров поиска вам не нужен, то просто пропустите его.\n");

            // Обрабатываем клиентов из файла ДО ввода от пользователя т.к. в случае проблем с файлом, ввод может быть бесполезен.
            IEnumerable<Client> clients = new List<Client>();

            try
            {
                FileReader fh = new FileReader();
                String[] dataFromFile = fh.ReadFromFile(@"./input.txt");
                clients = ClientParser.ParseClients(dataFromFile);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден");
            }
            catch (Exception e)
            {
                Console.WriteLine("Что-то пошло не так. Возникла ошибка: " + e.Message + e.InnerException + e.StackTrace);
            }
                        
            Console.WriteLine("Введите имя клиента: ");
            String name = Console.ReadLine();
            Console.WriteLine("Введите фамилию клиента: ");
            String surname = Console.ReadLine();
            Console.WriteLine("Введите отчество клиента: ");
            String patronymic = Console.ReadLine();
            Console.WriteLine("Введите банк клиента: ");
            String bank = Console.ReadLine();

            // Передаём параметры фильтрации и получаем результат.
            try
            {
                IEnumerable<Client> selection = ClientFilter.FilterByParameters(clients, name, surname, patronymic, bank);

                // Осуществляем сериализацию объектов и запись в выходной файл.
                Serializer.SerializeClients(selection.ToList());
            }
            catch (ClientNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
