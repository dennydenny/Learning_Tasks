using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LINQ_XML
{
    class FileReader
    {
        /// <summary>
        /// Читает данные из файла.
        /// </summary>
        /// <param name="filepath">Путь к файлу, из которого необходимо прочитать данные.</param>
        /// <returns>Массив строчек, прочитанных из файла.</returns>
        public String [] ReadFromFile(string filepath)
        {
                if (!filepath.Equals(""))
                {
                    if (File.Exists(filepath))
                    {
                        return File.ReadAllLines(filepath);
                    }
                    else
                    {
                        throw new FileNotFoundException();
                    }
                }
                else
                {
                    throw new FileNotFoundException();
                }
        }
    }
}
