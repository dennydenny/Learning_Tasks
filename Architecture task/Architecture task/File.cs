using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Architecture_task
{
    class File
    {
        /*
         * Файл:
         * 1. Имя
         * 2. Родитель
         * 3. Полный путь
         * 4. Тип (папка/файл)
         * 
         * Папка:
         * 1. Имя
         * 2. Родитель
         * 3. Полный путь
         * 4. Тип (папка/файл)
         * 5. Список элементов в этой папке
         */
        public String Name { get; set; }
        public String ParentName { get; set; }
        public String FullPath {
            get
            {
                return ParentName + Name;
            }
        }
        public String Type { 
            get
            {
                return "File";
            } 
        }
    }
}
