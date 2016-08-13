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
        /// Метод, создающий экземпляры узла файловой системы.
        /// </summary>
        /// <param name="path">Путь, в котором необходимо создать узел.</param>
        /// <param name="type">Тип узла (0 - файл, 1 - папка).</param>
        public void Create(String path, int type)
        {
            String[] foldersInPath = path.Split('\\');

            // Проверяем, что первым элементом является корень.
            if (!foldersInPath[0].Equals("root"))
            {
                throw new Exception("\nНеверно указан корневой каталог.");
            }

            Node first;

            // Осуществляем поиск первого узла, указанного после корня ([0] - всегда корень).
            try
            {
                first = root.Content.Single(n => n.Name == foldersInPath[1]);
            }
            // Выброс этого исключения означает, что первого узла, указанного после корня не существует.
            catch (System.InvalidOperationException)
            {
                throw new Exception ("\nУказанного пути не существует");
            }

            Folder temp = new Folder();

            while (temp.Content != null)
            {
            }

            for (int i = 1; i < foldersInPath.Count() - 1; i++)
            {
                //InvalidCastException
                //Folder current = (Folder)first;
            }

        }
    }
}
