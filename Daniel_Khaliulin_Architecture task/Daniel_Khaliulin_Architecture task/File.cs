using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Architecture_task
{
    class File : Node
    {
        public File(String name, Folder parent)
        {
            if (name != null)
            {
                this.Name = name;
            }
            else
            {
                throw new ArgumentNullException("Имя файла не может быть пустым.");
            }

            if (parent != null)
            {
                this.Parent = parent;
            }
            else
            {
                throw new ArgumentNullException("Родительская папка не может быть null.");
            }
        }
    }
}
