using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Task4
{
    class User
    {
        private int _digitFlag;

        private String _surname;
        public String Surname
        {
            get { return _surname; }
            set {
                if (!Int32.TryParse(value, out _digitFlag))
                {
                    if (!value.Equals("") && value.Trim().Length > 0)
                    {
                        _surname = value;
                    }
                    else
                    {
                        Console.WriteLine("Фамилия должна состоять хотя бы из одной буквы");
                    }
                }
                else
                {
                    Console.WriteLine("Фамилия должна состоять только из букв");
                }
            }
        }

        private String _name;
        public String Name
        {
            get { return _name; }
            set {
                if (!Int32.TryParse(value, out _digitFlag))
                {
                    if (!value.Equals("") && value.Trim().Length > 0)
                    {
                        _name = value;
                    }
                    else
                    {
                        Console.WriteLine("Имя должно состоять хотя бы из одной буквы");
                    }
                }
                else
                {
                    Console.WriteLine("Имя должно состоять только из букв");
                }
            }
        }

        private String _patronymic;
        public String Patronymic
        {
            get { return _patronymic; }
            set {
                if (!Int32.TryParse(value, out _digitFlag))
                {
                    if (!value.Equals("") && value.Trim().Length > 0)
                    {
                        _patronymic = value;
                    }
                    else
                    {
                        Console.WriteLine("Отчетство должно состоять хотя бы из одной буквы");
                    }
                }
                else
                {
                    Console.WriteLine("Отчетство должно состоять только из букв");
                }
            }
        }

        private DateTime _birthday;
        public DateTime Birthday
        {
            get { return _birthday; }
            set {
                _birthday = value;
            }
        }

        private int _age;
        public int Age
        {
            get {
                if (this.Birthday != DateTime.MinValue)
                {
                    _age = DateTime.Now.Year - this.Birthday.Year;
                    return _age;
                }
                else
                {
                    Console.WriteLine("Не задана дата рождения.");
                    return 0;
                }
            }
        }

    }
}
