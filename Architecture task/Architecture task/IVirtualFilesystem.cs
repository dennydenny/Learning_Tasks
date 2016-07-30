using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Architecture_task
{
    interface IVirtualFilesystem
    {
        void CreateFolder (Folder node);

        void CreateFile (IFileSystemNode node);

        void Copy (String from, String to);
        // Не забыть проверку на тип назначения.
        // Найти в списке папки from нужный элемент, на его основе создать новый объект и доавить созданный объект в список to

        void Move(String from, String to);
        // Найти в списке папки from нужный элемент, на его основе создать новый объект, удалить объект из списка и доавить созданный объект в список to

        void Remove(String itemName, String from);

        void GetTree();

    }
}
