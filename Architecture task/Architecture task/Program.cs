using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Architecture_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение представляет из себя виртуальную файловую систему\nДля работы с файловой системой доступны следующие команды:");
            bool isCommandSelected = false;
            VirtualFileSystem vfs = new VirtualFileSystem();
            Folder root = new Folder("root",  @"\");
            vfs.CreateFolder(root);

            while (1 == 1)
            {
                Console.WriteLine("\ncreatefolder - создать папку\ncreatefile - создать файл\ncopy - копировать элемент\nmove - переместить элемент\nremove - удалить элемент\ntree - вывести дерево элементов файловой системы");
                String choose = Console.ReadLine();
                switch (choose)
                {
                    case "createfolder":
                        isCommandSelected = true;
                        Console.WriteLine("Введите имя папки");
                        String folderName = Console.ReadLine();
                        Console.WriteLine("Введите имя папки, в которой вы бы хотели создать папку:");
                        String parentName = Console.ReadLine();
                        vfs.CreateFolder(new Folder( folderName, parentName));
                        break;

                    case "createfile":
                        isCommandSelected = true;
                        Console.WriteLine("!!!!");
                        break;

                    case "copy":
                        isCommandSelected = true;
                        Console.WriteLine("!!!!");
                        break;

                    case "move":
                        isCommandSelected = true;
                        Console.WriteLine("!!!!");
                        break;
                    case "remove":
                        isCommandSelected = true;
                        Console.WriteLine("!!!!");
                        break;

                    case "tree":
                        isCommandSelected = true;
                        vfs.GetTree();
                        break;

                    default:
                        Console.WriteLine("Пожалуйста, наберите одну из команд.");
                        break;
                }
            }
        }

    }
}
