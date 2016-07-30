using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Architecture_task
{
    class VirtualFileSystem : IVirtualFilesystem
    {
        private List<IFileSystemNode> _content = new List<IFileSystemNode>();
        public List<IFileSystemNode> Content
        {
            get
            {
                return _content;
            }
            private set
            {
                _content = value;
            }
        }

        public void CreateFolder(Folder node)
        {
            if (this._content != null)
            {
                // Проверка существования указанного родителя.
                if (!this._content.Exists(n => n.Name == node.ParentName && n.Type == "Folder"))
                {
                    throw new Exception("Parent folder are not exist.");
                }
                // Проверяем дубликат имени в родителе.
                else if (this._content.Exists(n => n.Name == node.Name && n.Type == node.Type && n.ParentName == node.ParentName))
                {
                    throw new Exception("Folder with same name already exist. Please, choose different name.");
                }
                else
                {
                    this._content.Add(node);
                }               
            }
            else Console.WriteLine("Content is null");
        }

        public void CreateFile(IFileSystemNode node)
        {
            if (this._content != null)
            {
                // Проверка существования указанной папки-родителя.
                if (!this._content.Exists(n => n.Name == node.ParentName && n.Type == "Folder"))
                {
                    throw new Exception("Parent folder are not exist.");
                }
                // Проверяем дубликат имени в родителе.
                else if (this._content.Exists(n => n.Name == node.Name && n.Type == node.Type && n.ParentName == node.ParentName))
                {
                    throw new Exception("File with same name already exist. Please, choose different name.");
                }
                else
                {
                    this._content.Add(node);
                }
            }
            else Console.WriteLine("Content is null");
        }

        public void Copy(String from, String to)
        { 
        }
        // Не забыть проверку на тип назначения.
        // Найти в списке папки from нужный элемент, на его основе создать новый объект и доавить созданный объект в список to

        public void Move(String from, String to)
        { 
        }
        // Найти в списке папки from нужный элемент, на его основе создать новый объект, удалить объект из списка и доавить созданный объект в список to

        public void Remove(String itemName, String from)
        { 
        }

        // TODO: Реализовать вывод дерева каталогов именно для выбранного пути.
        public void GetTree()
        {
            foreach (Folder folder in _content)
            {
                Console.WriteLine("Name: {0}, Parent: {1}, FullPath: {2}, Type: {3}", folder.Name, folder.ParentName, folder.FullPath, folder.Type);
            }

        }
    }
}
