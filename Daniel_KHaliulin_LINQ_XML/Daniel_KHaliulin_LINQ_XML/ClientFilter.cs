using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LINQ_XML
{
    public static class ClientFilter
    {
        public static IEnumerable<Client> FilterByParameters(IEnumerable<Client> clients, String name, String surname, String patronymic, String bank)
        {
            // Массив ненулевых параметров, которые были переданы.
            Client fantomClient = new Client(name, surname, patronymic, bank);
            IEnumerable filterParams = checkParametersForNull(fantomClient);
            IEnumerable<Client> result = null;

            // Осуществляем проход по элементам массива и при обнаружении параметра осуществляем фильтрацию по нему.
            foreach (string parameter in filterParams)
            {
                switch (parameter)
                {
                    case "Surname":
                        result = clients.Where(c => c.Surname == surname);
                        break;

                    case "Name":
                        result = clients.Where(c => c.Name == name);
                        break;

                    case "Patronymic":
                        result = clients.Where(c => c.Patronymic == patronymic);
                        break;

                    case "Bank":
                        result = clients.Where(c => c.Bank == bank);
                        break;
                }      
            }

            // Проверка количества результатов поиска.
            if (result.Count() < 1)
            {
                throw new ClientNotFoundException("По заданным параметрам клиент не найден");
            }

            return result;
        }

        /// <summary>
        /// Осуществляет проверку значений параметров фильтрации списка клиентов на существование.
        /// </summary>
        /// <param name="fantomClient">Экземпляр объекта Client с параметрами, по которым необходимо осуществить фильтрацию клиентов.</param>
        /// <returns>Коллекция названий параметров, по которым необходимо осуществить фильтрацию клиентов.</returns>
        private static IEnumerable checkParametersForNull(Client fantomClient)
        {
            List<String> checkedParameters = new List<string>();
            if (!fantomClient.Name.Trim().Equals(""))
            {
                checkedParameters.Add("Name");
            }

            if (!fantomClient.Surname.Trim().Equals(""))
            {
                checkedParameters.Add("Surname");
            }

            if (!fantomClient.Patronymic.Trim().Equals(""))
            {
                checkedParameters.Add("Patronymic");
            }

            if (!fantomClient.Bank.Trim().Equals(""))
            {
                checkedParameters.Add("Bank");
            }

            // Если не задано ни одного параметра поиска, то поиск осуществлять не будет.
            if (checkedParameters.Count < 1)
            {
                throw new ArgumentException("Невозможно найти клиента по пустым параметрам поиска");
            }

            return checkedParameters;
        }
    }
}
