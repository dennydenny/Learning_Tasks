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
            // TODO: Проверка параметров.
            this.Name = name;
            this.Parent = parent;
        }
    }
}
