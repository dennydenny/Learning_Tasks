using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приложение описывает сотрудника с набором свойств (фамилия, имя, отчество, дата рождения, возраст, стаж работы и должность) и выводит информацию о нём.");
            Console.WriteLine();

            Employee employee = new Employee();

            // Surname.
            # region Surname
            while (String.IsNullOrEmpty(employee.Surname))
            {
                Console.Write("Введите фамилию: ");
                employee.Surname = Console.ReadLine();
            }
            #endregion

            // Name.
            #region Name
            while (String.IsNullOrEmpty(employee.Name))
            {
                Console.Write("Введите имя: ");
                employee.Name = Console.ReadLine();
            }
            #endregion

            // Patronymic
            # region Patronymic.
            while (String.IsNullOrEmpty(employee.Patronymic))
            {
                Console.Write("Введите отчетство: ");
                employee.Patronymic = Console.ReadLine();
            }
            #endregion

            // Birthday
            # region Birthday.
            while (employee.Birthday == DateTime.MinValue)
            {
                Console.Write("Введите дату рождения (формат dd.MM.yyyy): ");
                String birthday = Console.ReadLine();
                employee.Birthday = DateTime.ParseExact(birthday, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            #endregion

            // Experiense
            #region Experiense

            while (employee.Experience == 0) {
                Console.Write("Введите стаж работы: ");
                String _experience = Console.ReadLine();
                int _IntExperience;

                if (Int32.TryParse(_experience, out _IntExperience))
                {
                    employee.Experience = _IntExperience;
                }
                else 
                {
                    Console.WriteLine("Стаж работы должен быть натуральным числом. Пожалуйста, введите стаж работы.");
                }
            }
            #endregion

            // Position
            # region Position.
            while (String.IsNullOrEmpty(employee.Position))
            {
                Console.Write("Введите должность: ");
                employee.Position = Console.ReadLine();
            }
            #endregion


            // Output
            # region Output.
            Console.WriteLine();
            Console.WriteLine("Информация о сотруднике:");
            Console.WriteLine("Фамилия: {0}", employee.Surname);
            Console.WriteLine("Имя: {0}", employee.Name);
            Console.WriteLine("Отчество: {0}", employee.Patronymic);
            Console.WriteLine("Дата рождения: {0: dd.MM.yyyy}", employee.Birthday);
            Console.WriteLine("Возраст: {0}", employee.Age);
            Console.WriteLine("Стаж работы: {0}", employee.Experience);
            Console.WriteLine("Должность: {0}", employee.Position);
            Console.ReadKey();
            #endregion

        }
    }
}
