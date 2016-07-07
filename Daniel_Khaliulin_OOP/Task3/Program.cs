using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение описывает человека со набором свойств (фамилия, имя, отчество, дата рождения, возраст) и выводит информацию о нём.");
            Console.WriteLine();

            User user = new User();

            // Surname.
            # region Surname
            while (String.IsNullOrEmpty(user.Surname))
            {
                Console.Write("Введите фамилию: ");
                user.Surname = Console.ReadLine();
            }
            #endregion

            // Name.
            #region Name
            while (String.IsNullOrEmpty(user.Name))
            {
                Console.Write("Введите имя: ");
                user.Name = Console.ReadLine();
            }
            #endregion

            // Patronymic
            # region Patronymic.
            while (String.IsNullOrEmpty(user.Patronymic))
            {
                Console.Write("Введите отчетство: ");
                user.Patronymic = Console.ReadLine();
            }
            #endregion

            // Birthday
            # region Birthday.
            while (user.Birthday == DateTime.MinValue)
            {
                Console.Write("Введите дату рождения (формат dd.MM.yyyy): ");
                String birthday = Console.ReadLine();

                user.Birthday = DateTime.ParseExact(birthday, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            #endregion

            // Output
            # region Output.
            Console.WriteLine();
            Console.WriteLine("Информация о пользователе:");
            Console.WriteLine("Фамилия: {0}", user.Surname);
            Console.WriteLine("Имя: {0}", user.Name);
            Console.WriteLine("Отчество: {0}", user.Patronymic);
            Console.WriteLine("Дата рождения: {0: dd.MM.yyyy}", user.Birthday);
            Console.WriteLine("Возраст: {0}", user.Age);
            Console.ReadKey();
            #endregion
            
        }
    }
}
