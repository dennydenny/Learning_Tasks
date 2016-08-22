using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Architecture_task
{
    public class Folder : Node
    {
        public ICollection<Node> Content;

        /// <summary>
        /// Конструктор, инициирующий экземпляр класса папки.
        /// </summary>
        /// <param name="name">Имя папки.</param>
        /// <param name="parent">Ссылка на родительскую папку.</param>
        public Folder(String name, Folder parent)
        {
            if (name != null)
            {
                this.Name = name;
            }
            else
            {
                throw new ArgumentNullException("Имя папки не может быть пустым.");
            }

            // Исключение для папки root.
            if (!this.Name.Equals("root"))
            {
                if (parent != null)
                {
                    this.Parent = parent;
                }
                else
                {
                    throw new ArgumentNullException("Родительская папка не может быть null.");
                }
            }
            else
            {
                this.Parent = parent;
            }
            Content = new List<Node>();
        }

        /// <summary>
        /// Метод, осуществляющий проверку, содержится ли элемент с входным именем в коллекции элементов папки.
        /// </summary>
        /// <param name="name">Имя искомого элемента.</param>
        /// <returns>true, если искомый элемент существует в этой папки, иначе false.</returns>
        public bool IsNodeExists(String name)
        {
            if (String.IsNullOrEmpty(name)) throw new ArgumentNullException("Отсутствует имя для проверки");

            if (this.Content.Any(n => n.Name == name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
