using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Architecture_task
{
    public class VirtualFilesystem : IVirtualFilesystem
    {
        private Folder _root;
        public Folder root
        {
            get
            {
                return _root;
            }
            private set
            {
                _root = value;
            }
        }
        
        public VirtualFilesystem()
        {
            root = new Folder("root", null);
        }

        /// <summary>
        /// Метод, создающий экземпляры папки в файловой системе.
        /// </summary>
        public void CreateFolder(String path)
        {
            String[] foldersInPath = path.Split('\\');

            // Проверяем, что первым элементом является корень.
            if (!foldersInPath[0].Equals("root"))
            {
                throw new Exception("\nНеверно указан корневой каталог.");
            }
            Folder temp = root;

            for (int i = 1; i < foldersInPath.Count(); i++)
            {
                try
                {
                    if (i == (foldersInPath.Count() - 1))
                    {
                        temp.Content.Add(new Folder(foldersInPath[i], temp));
                    }
                    
                    temp = temp.Content.Single(n => n.Name == foldersInPath[i]) as Folder;
                }
                catch (InvalidOperationException)
                {
                    throw new Exception("\nВведённый путь не недействителен.");
                }
            }
        }

        /// <summary>
        /// Метод, создающий файл в файловой системе.
        /// </summary>
        /// <param name="path">Путь с указанием файла, в котором необходимо создать файл.</param>
        public void CreateFile(String path)
        {
            String[] itemsInPath = path.Split('\\');

            // Проверяем, что первым элементом является корень.
            if (!itemsInPath[0].Equals("root"))
            {
                throw new Exception("\nНеверно указан корневой каталог.");
            }
            Folder temp = root;

            for (int i = 1; i < itemsInPath.Count(); i++)
            {
                try
                {
                    if (i == (itemsInPath.Count() - 1))
                    {
                        temp.Content.Add(new File(itemsInPath[i], temp));
                    }

                    temp = temp.Content.Single(n => n.Name == itemsInPath[i]) as Folder;
                }
                catch (InvalidOperationException)
                {
                    throw new Exception("\nВведённый путь не недействителен.");
                }
            }
        }

        public void GetTree()
        {
            Folder tree = root;
            List<Node> firstStack = new List<Node>();
            firstStack.Add(tree);

            List<List<Node>> childListStack = new List<List<Node>>();
            childListStack.Add(firstStack);

            while (childListStack.Count > 0)
            {
                List<Node> childStack = childListStack[childListStack.Count - 1];

                if (childStack.Count == 0)
                {
                    childListStack.RemoveAt(childListStack.Count - 1);
                }
                else
                {
                    tree = childStack[0] as Folder;
                    childStack.RemoveAt(0);

                    string indent = "";
                    for (int i = 0; i < childListStack.Count - 1; i++)
                    {
                        indent += (childListStack[i].Count > 0) ? "|  " : "   ";
                    }

                    Console.WriteLine(indent + "+- " + tree.Name);

                    if (tree.Content.Count > 0)
                    {
                        childListStack.Add(new List<Node>(tree.Content));
                    }
                }
            }
        }
    }
}
