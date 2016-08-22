using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Architecture_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение представляет из себя виртуальную файловую систему\nДля работы с файловой системой доступны следующие команды:");
            IVirtualFilesystem vfs = new VirtualFilesystem();

            while (1 == 1)
            {
                Console.WriteLine("\nmkdir [path] - создать папку\nmkfile [path]- создать файл\ncopy [from] [to] - копировать элемент\nmove [from] [to] - переместить элемент\nremove [from] - удалить элемент\ntree - вывести дерево элементов файловой системы\nman - вывессти краткий help по работе с системой\n");
                String userInput = Console.ReadLine();
                String [] inputArgs = userInput.Split(' ');

                try
                {
                    // Осуществляем проверку данных.
                    CheckInputParameters(inputArgs);

                    switch (inputArgs[0])
                    {
                        case ("mkdir"):
                            vfs.CreateFolder(inputArgs[1]);
                            break;
                        case ("mkfile"):
                            vfs.CreateFile(inputArgs[1]);
                            break;
                        case ("copy"):
                            vfs.Copy(inputArgs[1], inputArgs[2]);
                            break;
                        case ("move"):
                            vfs.Move(inputArgs[1], inputArgs[2]);
                            break;
                        case ("remove"):
                            vfs.Remove(inputArgs[1]);
                            break;
                        case ("tree"):
                            vfs.GetTree();
                            break;
                        case ("man"):
                            Console.WriteLine("\nПримеры корректных команд: \nmkdir root\\test\nmkfile root\\test\\file.zip\ncopy root\\test\\file.zip root\\test2\nmove root\\test\\file.zip root\\test2\nremove root\\test\\file.zip\ntree");
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Метод, реализующий общую проверку введённых пользователем данных.
        /// </summary>
        /// <param name="inputArgs"></param>
        private static void CheckInputParameters(String[] inputArgs)
        {
            // Проверка пустого ввода.
            if (String.IsNullOrEmpty(inputArgs[0]))
            {
                throw new Exception("\nВы ввели пустое значение.");
            }

            // Проверка максимального числа элементов в запросе.
            if (inputArgs.Count() > 3)
            {
                throw new Exception("\nНекорректное количество параметров введённой команды");
            }

            // Возможные варианты команд.
            String [] availableCommands = {"mkdir", "mkfile", "copy", "move", "remove", "tree", "man"};

            // Проверяем, что введена одна из существующих команд.
            if (!availableCommands.Contains(inputArgs[0]))
            {
                throw new Exception("\nТакой команды не существует.");
            }

            // Команды copy и move имеют по два аргумента, проверяем их существование. 
            if (inputArgs[0].Equals("copy") || inputArgs[0].Equals("move"))
            {
                if (inputArgs.Count() != 3)
                {
                    throw new Exception("\nНекорректное количество аргументов команды");
                }
            }

            // Команды mkdir, mkfile и remove имеют по одному аргументу, проверяем их существование. 
            if (inputArgs[0].Equals("mkdir") || inputArgs[0].Equals("mkfile") || inputArgs[0].Equals("remove"))
            {
                if (inputArgs.Count() != 2)
                {
                    throw new Exception("\nНекорректное количество аргументов команды");
                }
            }
        }
    }
}
