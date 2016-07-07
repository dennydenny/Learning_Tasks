using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class Line : BaseClass
    {
        public override double Lenght
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина должна быть больше нуля");
                }
                else {
                    this._lenght = value;
                }
            }
        }

        public void SetLenght() {
            Console.WriteLine("Пожалуйста, введите длину");
            double l;
            if (!Double.TryParse(Console.ReadLine(), out l))
            {
                Console.WriteLine("Длина должна быть числом");
            }
            else
            {
                this.Lenght = l;
            }
        }
    }
}
