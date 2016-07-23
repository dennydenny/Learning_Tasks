using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_XML
{
    [Serializable]
    public class Client
    {
        public String Bank { get; set; }

        private String _name;
        public String Name { get; set; }

        private String _surname;
        public String Surname { get; set; }

        private String _patronymic;
        public String Patronymic { get; set; }

        private DateTime _birthday;
        public DateTime Birthday { 
            get
            {
                return _birthday.Date;
            } 
            set
            {
            }
        }

        /// <summary>
        /// Стандартный конструктор без параметров для возможности сериализации.
        /// </summary>
        public Client()
        { }

        /// <summary>
        /// Конструктор создания нового экземпляря клиента.
        /// </summary>
        /// <param name="personalInfo">Персональная информация клиента (ФИО, дата рождения).</param>
        /// <param name="bank">Банк клиента.</param>
        public Client(String personalInfo, String bank)
        {
            // Обрабатываем персональные данные клиента.
            if (!String.IsNullOrEmpty(personalInfo.Trim()))
            {
                // Данные состоят из двух секций, разделённых запятой: ФИО и дата рождения (прим. Филимонов Антон, 11.11.2011).
                // Разделяем на секции с помощью разделителя.
                String[] sections = personalInfo.Split(',');

                // Прорабатывает секцию с ФИО.
                String[] FIO = sections[0].TrimStart().TrimEnd().Split(' ');

                // В зависимости от длины массива с ФИО проставляем имя, фамилию и отчество.
                if (FIO.Length > 0)
                {
                    _name = FIO[0];
                    this.Name = _name;

                    if (FIO.Length > 1)
                    {
                        this.Name = _name;
                        _surname = FIO[1];
                        this.Surname = _surname;

                        if (FIO.Length > 2)
                        {
                            this.Name = _name;
                            this.Surname = _surname;
                            _patronymic = FIO[2];
                            this.Patronymic = _patronymic;
                        }
                    }
                }

                _birthday = DateTime.ParseExact(sections[1].Trim(), "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);

                if (!String.IsNullOrEmpty(bank))
                {
                    this.Bank = bank.TrimStart().TrimEnd();
                }
                else
                {
                    throw new ArgumentException();
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public Client(String name, String surname, String patronymic, String bank)
        {
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.Bank = bank;
        }
    }
}
