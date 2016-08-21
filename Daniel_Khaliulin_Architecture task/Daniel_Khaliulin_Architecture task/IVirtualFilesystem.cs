using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Architecture_task
{
    interface IVirtualFilesystem
    {
        /// <summary>
        /// Метод, создающий экземпляры папки в файловой системе.
        /// </summary>
        void CreateFolder (String path);

        /// <summary>
        /// Метод, содающий экземпляры файлов в файловой системе.
        /// </summary>
        /// <param name="path">Путь до файла (послений элемент - имя файла).</param>
        void CreateFile(String path);

        // Следующие методы интерфейса закомментированы в целях более удобной отладки. Чтобы студия не регалась, на то, что в ребёнки они не реализованы.
        
        /// <summary>
        /// Метод, осуществляющий копирование элементов из одного места в другое.
        /// </summary>
        /// <param name="from">Путь к узлу, который надо скопировать.</param>
        /// <param name="to">Путь, в который нужно осуществить копирование.</param>
        void Copy(String from, String to);

        
        /// <summary>
        /// Метод, осуществляющий перемещение элементов из одного места в другое.
        /// </summary>
        /// <param name="from">Путь к узлу, который надо переместить.</param>
        /// <param name="to">Путь, в который нужно осуществить перемещение.</param>
        void Move(String from, String to);
        /*
        /// <summary>
        /// Метод, осуществляющий удаление узла файловой системы.
        /// </summary>
        /// <param name="path">Путь к узлу, который необходимо удалить.</param>
        void Remove(String path);
        */
        /// <summary>
        /// Возвращает древо каталогов файловой системы.
        /// </summary>
        void GetTree();
          
    }
}
