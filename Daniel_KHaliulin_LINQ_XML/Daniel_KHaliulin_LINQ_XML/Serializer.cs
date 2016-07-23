using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace LINQ_XML
{
    public static class Serializer
    {
        /// <summary>
        /// Осуществляет сериализацию списка в XML и записывает данные в файл.
        /// </summary>
        /// <param name="clients">Список отфильтрованных клиентов.</param>
        public static void SerializeClients (List<Client> clients)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Client>));

            using (FileStream fs = new FileStream("output.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, clients);
            }
        }
    }
}
