using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Architecture_task
{
    class Folder :  IFileSystemNode
    {
        // Имя папки.
        public String Name { get; set; }

        // Имя родителя.
        public String ParentName { get; set; }

        // Полный путь до папки.
        public String FullPath
        {
            get
            {
                return ParentName + @"\" + Name;
            }
        }

        // Тип узла???
        public String Type
        {
            get
            {
                return "Folder";
            }
        }

        // Список элементов в папке.
        private List<Folder> _items = new List<Folder>();
        public List<Folder> Items 
        { 
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Конструктор, инициирующий экземпляр папки.
        /// </summary>
        /// <param name="name">Имя папки.</param>
        /// <param name="parentName">Имя родительской папки.</param>
        public Folder(String name, String parentName)
        {
            this.Name = name;
            this.ParentName = parentName;
        }
    }
}
