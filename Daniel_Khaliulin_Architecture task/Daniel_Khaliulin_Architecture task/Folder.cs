using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Architecture_task
{
    public class Folder : Node
    {
        public ICollection<Node> Content;
        public Folder Parent { get; private set; }

        /// <summary>
        /// Конструктор, инициирующий экземпляр класса папки.
        /// </summary>
        /// <param name="name">Имя папки.</param>
        /// <param name="parent">Ссылка на родительскую папку.</param>
        public Folder(String name, Folder parent)
        {
            // TODO: проверки параметров.
            this.Name = name;
            this.Parent = parent;
            Content = new List<Node>();
        }

        public Folder()
        {
        }
    }
}
