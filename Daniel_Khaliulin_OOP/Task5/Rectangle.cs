using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class Rectangle : Line
    {
        private double _s;
        public double S {
            get {
                    _s = _width * _lenght;
                    return _s;
            }
        }

        private double _width;
        public double Width { 
            get {return _width;}
            set {
                if (value <= 0)
                {
                    Console.WriteLine("Ширина должна быть больше нуля");
                }
                else {
                    this._width = value;
                }
            }
        }

        public void SetWidth()
        {
            Console.WriteLine("Пожалуйста, введите ширину");
            double w;
            if (!Double.TryParse(Console.ReadLine(), out w))
            {
                Console.WriteLine("Ширина должна быть числом");
            }
            else
            {
                this.Width = w;
            }
        }
    }
}
