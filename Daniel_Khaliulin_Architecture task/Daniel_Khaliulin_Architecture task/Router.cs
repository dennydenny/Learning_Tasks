using System;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Architecture_task
{
    public static class Router
    {
        private IVirtualFilesystem _vfs = new VirtualFilesystem();

        /// <summary>
        /// Метод, осуществляющий маршрутизацию между методами файловой системы.
        /// </summary>
        /// <param name="inputArgs">Команда и аргументы, введённые пользователем.</param>
        public static void Route(String[] inputArgs)
        {
            // Первый элемент массива - сама введённая команда.

            switch (inputArgs[0])
            {
                case ("mkdir"):
                    
                    //VirtualFilesystem.Create(inputArgs[1], 1);
                    break;
                case ("mkfile"):
                    break;
                case ("copy"):
                    break;
                case ("move"):
                    break;
                case ("remove"):
                    break;
                case ("tree"):
                    break;
                default:
                    break;

            }


        }
    }
}
