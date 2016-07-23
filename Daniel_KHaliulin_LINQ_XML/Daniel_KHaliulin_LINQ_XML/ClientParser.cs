using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Text.RegularExpressions;

namespace LINQ_XML
{
    public static class ClientParser
    {
        /// <summary>
        /// Парсит клиентов банка из переданной неструктурированной коллекции.
        /// </summary>
        /// <param name="source">Коллекция - источник клиентов банка.</param>
        /// <returns>Коллекция объектов "клиент".</returns>
        public static IEnumerable<Client> ParseClients(IEnumerable source)
        {
            Regex bankRegex = new Regex("(?<=Банк:).*", RegexOptions.Multiline);
            Regex clientRegex = new Regex("(?<=Клиент:).*", RegexOptions.Multiline);

            List<Client> clients = new List<Client>();

            StringBuilder bank = new StringBuilder();

            foreach (String item in source)
            {
                // Учитываем, что в входном значении могут быть пустые строки.
                if (String.IsNullOrWhiteSpace(item))
                {
                    continue;
                }

                Match bankMatch = bankRegex.Match(item);
                if (bankMatch.Success)
                {
                    bank.Clear();
                    bank.Append (bankMatch.Groups[0].Value);
                }
                else
                {
                    Match clientMatch = clientRegex.Match(item);
                    clients.Add(new Client(clientMatch.Groups[0].Value, bank.ToString()));
                }
            }
            return clients;
        }
    }
}
