using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LINQ_XML
{
    class FileHelper
    {
        public String ReadFromFile(string filepath)
        {
            try
            {
                // Check is filepath empty.
                if (!filepath.Equals(""))
                {
                    // Check is filepath exist
                    if (File.Exists(filepath))
                    {
                        return File.ReadAllText(filepath);
                    }
                    else
                    {
                        Console.WriteLine("Файла не существует :(. Поиск осуществлялся в " + filepath);
                        throw new FileNotFoundException();
                    }
                }
                else
                {
                    Console.WriteLine("Путь к исходному файлу не может быть пустым.");
                    throw new FileNotFoundException();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} {1}", e.Message, e.StackTrace);
                return "";
            }
        }
    }
}
