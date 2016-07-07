using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class Circle : Line
    {
        private double _r;
        public double R {
            get { return _r;}
            set {
            {
                if (value <= 0)
                {
                    Console.WriteLine("Радиус должен быть больше нуля");
                }
                else {
                    this._r = value;
                }
            }
            }
        }

        public void SetR()
        {
            // Radius.
            Console.WriteLine("Пожалуйста, введите радиус R");
            double r;
            if (!Double.TryParse(Console.ReadLine(), out r))
            {
                Console.WriteLine("Радиус должен быть числом");
            }
            else
            {
                this.R = r;
            }
        }
    }
}
