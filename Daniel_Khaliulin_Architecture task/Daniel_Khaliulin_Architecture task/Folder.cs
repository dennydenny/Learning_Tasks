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
            // TODO: проверки параметров.
            this.Name = name;
            this.Parent = parent;
            Content = new List<Node>();
        }

        public Folder()
        {
        }   


        private IList<Node> Select(IEnumerable<Node> source, Func<Node, bool> predicate)
        {
            var res = new List<Node>();
            foreach (var treeITem in source)
            {
                var folder = treeITem as Folder;
                if (folder != null)
                    res.AddRange(Select(folder.Content, predicate));

                if (predicate(treeITem))
                    res.Add(treeITem);
            }
            return res;
        }

        // внешняя обертка а-ля LINQ, работающая через предикат
        public IList<Node> Select(Func<Node, bool> predicate)
        {
            return Select(this.Content, predicate);
        }

        /* http://ru.stackoverflow.com/questions/277683/linq-%D0%BF%D0%BE%D0%B8%D1%81%D0%BA-%D0%B2-%D0%BA%D0%BE%D0%BB%D0%BB%D0%B5%D0%BA%D1%86%D0%B8%D0%B8-%D0%BA%D0%BE%D0%BB%D0%BB%D0%B5%D0%BA%D1%86%D0%B8%D0%B9
         * var res = FolderItem.Select(x => x.Enabled);
        // будет выведено 4 - количество вложенных элементов с Enabled == true 
        Console.WriteLine(res.Count());
         */
    }
}
