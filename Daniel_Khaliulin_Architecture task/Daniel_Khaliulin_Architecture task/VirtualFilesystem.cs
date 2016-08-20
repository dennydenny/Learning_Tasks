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
        public void CreateFolder (String path)
        {
            String[] itemsInPath = path.Split('\\');
            Folder temp = GoToFolder(itemsInPath);
            temp.Content.Add(new Folder(itemsInPath[itemsInPath.Count() - 1], temp));
        }

        /// <summary>
        /// Метод, создающий файл в файловой системе.
        /// </summary>
        /// <param name="path">Путь с указанием файла, в котором необходимо создать файл.</param>
        public void CreateFile (String path)
        {
            String[] itemsInPath = path.Split('\\');
            Folder temp = GoToFolder(itemsInPath);
            temp.Content.Add(new File(itemsInPath[itemsInPath.Count() - 1], temp));
        }

        public void Copy(String from, String to)
        {
            /*
             * 1. Проверяем существует ли элемент для копирования (последний в входном пути)
             * 2. Проверяем существует ли путь назначения.
             * 3. Делаем рекурсивный...TBD
             */
        }

        /// <summary>
        /// Метод, выводящий древовидную структуру виртуальной файловой системы в консоль.
        /// </summary>
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
                    Node current = childStack[0];
                    childStack.RemoveAt(0);

                    string indent = "";
                    for (int i = 0; i < childListStack.Count - 1; i++)
                    {
                        indent += (childListStack[i].Count > 0) ? "|  " : "   ";
                    }

                    Console.WriteLine(indent + "+- " + current.Name);

                    if (current is File)
                    {
                        continue;
                    }
                    Folder currentFolder = (Folder)current;

                    if (currentFolder.Content.Count > 0)
                    {
                        childListStack.Add(new List<Node>(currentFolder.Content));
                    }
                }
            }
        }

        /// <summary>
        /// Метод, осуществляющий "переход" к папке, указанной в входном пути.
        /// </summary>
        /// <param name="itemsInPath">Набор элементов файловой системы, по которым необходимо пройтись, чтобы достигнуть целевой папки (предпоследний элемент массива).</param>
        /// <returns>Ссылка на целевую папку.</returns>
        private Folder GoToFolder(String[] itemsInPath)
        {
            // Проверяем, что первым элементом является корень.
            if (!itemsInPath[0].Equals("root"))
            {
                throw new Exception("\nНеверно указан корневой каталог.");
            }
            Folder temp = root;

            for (int i = 1; i < itemsInPath.Count() - 1; i++)
            {
                try
                {
                    temp = temp.Content.Single(n => n.Name == itemsInPath[i]) as Folder;
                }

                catch (InvalidOperationException)
                {
                    throw new Exception("\nВведённый путь не недействителен.");
                }
            }
            return temp;
        }
    }
}
