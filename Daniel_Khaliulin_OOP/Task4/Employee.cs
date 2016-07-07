using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    class Employee : User
    {
        private int _experience;
        public int Experience {
            get { return _experience; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Стаж работы не можеть быть меньше нуля");
                }

                // Check is current age less then work experience.
                else if (value > this.Age)
                {
                    Console.WriteLine("Опыт работы не можеть быть больше возраста работника");
                }

                // Chech is child_labour detected.
                else if (18 > (this.Age - value))
                {
                    Console.WriteLine("Вас привлекали к детскому труду? Скажите, а вас было много? Мы уже выехали.");
                }
                else
                {
                    _experience = value;
                }
            }
        }

        private String _position;
        public String Position { 
            get {return _position;}
            set
            {
                if (!value.Equals(""))
                {
                    _position = value;
                }
                else 
                {
                    Console.WriteLine("Должность не можеть быть пустой.");
                }
            }
        }
    }
}
