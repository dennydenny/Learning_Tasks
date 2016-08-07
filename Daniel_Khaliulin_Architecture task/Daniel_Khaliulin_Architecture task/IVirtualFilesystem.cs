using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Architecture_task
{
    interface IVirtualFilesystem
    {
        /// <summary>
        /// Метод, создающий экземпляры узла файловой системы.
        /// </summary>
        /// <param name="path">Путь, в котором необходимо создать узел.</param>
        /// <param name="type">Тип узла (0 - файл, 1 - папка).</param>
        void Create (String path, int type);

        /*
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

        /// <summary>
        /// Метод, осуществляющий удаление узла файловой системы.
        /// </summary>
        /// <param name="path">Путь к узлу, который необходимо удалить.</param>
        void Remove(String path);

        /// <summary>
        /// Возвращает древо каталогов файловой системы.
        /// </summary>
        void GetTree();
         */ 
    }
}
