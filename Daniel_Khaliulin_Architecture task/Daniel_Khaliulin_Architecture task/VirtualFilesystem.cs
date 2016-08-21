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
            Folder temp = GoToFolder(itemsInPath, true);
            temp.Content.Add(new Folder(itemsInPath[itemsInPath.Count() - 1], temp));
        }

        /// <summary>
        /// Метод, создающий файл в файловой системе.
        /// </summary>
        /// <param name="path">Путь с указанием файла, в котором необходимо создать файл.</param>
        public void CreateFile (String path)
        {
            String[] itemsInPath = path.Split('\\');
            Folder temp = GoToFolder(itemsInPath, true);
            temp.Content.Add(new File(itemsInPath[itemsInPath.Count() - 1], temp));
        }

        /// <summary>
        /// Метод, осуществляющий копирование элементов FS между папками.
        /// </summary>
        /// <param name="pathFrom">Путь-источник с указанием узла, который необходимо скопировать.</param>
        /// <param name="pathTo">Целевой путь, в который необходимо осуществить копирование.</param>
        public void Copy(String pathFrom, String pathTo)
        {
            String[] itemsInFromPath = pathFrom.Split('\\');
            Folder sourceFolder = GoToFolder(itemsInFromPath, true);
            Node targetNode = sourceFolder.Content.Single(n => n.Name == itemsInFromPath[itemsInFromPath.Count() - 1]);

            String[] itemsInToPath = pathTo.Split('\\');
            Folder destinationFolder = GoToFolder(itemsInToPath, false);
            destinationFolder.Content.Add(targetNode);
        }

        /// <summary>
        /// Метод, осуществляющий перемещение элементов FS между папками.
        /// </summary>
        /// <param name="pathFrom">Путь-источник с указанием узла, который необходимо переместить.</param>
        /// <param name="pathTo">Целевой путь, в который необходимо осуществить перемещение.</param>
        public void Move(String pathFrom, String pathTo)
        {
            String[] itemsInFromPath = pathFrom.Split('\\');
            Folder sourceFolder = GoToFolder(itemsInFromPath, true);
            Node targetNode = sourceFolder.Content.Single(n => n.Name == itemsInFromPath[itemsInFromPath.Count() - 1]);

            String[] itemsInToPath = pathTo.Split('\\');
            Folder destinationFolder = GoToFolder(itemsInToPath, false);
            destinationFolder.Content.Add(targetNode);

            // Удаляем элемент из папки-источника.
            sourceFolder.Content.Remove(targetNode);
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
        /// <param name="itemsInPath">Набор элементов FS, которые необходимо "пройти", чтобы достигнуть целевой папки (предпоследний элемент массива).</param>
        /// <param name="stopOnParent">Если истина, то "переход" будет осуществлен только до последней родительской папки. Иначе "переход" будет будет осуществлен на последний элемент.</param>
        /// <returns></returns>
        private Folder GoToFolder(String[] itemsInPath, bool stopOnParent)
        {
            // Проверяем, что первым элементом является корень.
            if (!itemsInPath[0].Equals("root"))
            {
                throw new Exception("\nНеверно указан корневой каталог.");
            }
            Folder temp = root;

            // Если stopOnParent true, обход выполняется только до последней родительной папки. Иначе до последнего элемента в пути.
            int k = 1;
            if (!stopOnParent) k--;

            for (int i = 1; i < itemsInPath.Count() - k; i++)
            {
                try
                {
                    temp = temp.Content.Single(n => n.Name == itemsInPath[i]) as Folder;
                }

                catch (InvalidOperationException)
                {
                    throw new Exception("\nВведённый путь не недействителен.");
                }
                catch (Exception e)
                {
                    throw new Exception("\nВозникла ошибка при обработке: " + e.Message);
                }
            }
            return temp;
        }
    }
}
