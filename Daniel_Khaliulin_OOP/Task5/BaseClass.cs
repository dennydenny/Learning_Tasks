using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    abstract class BaseClass
    {
        public double X { get; set; }

        public double Y { get; set; }

        protected double _lenght;
        public virtual double Lenght { 
            get {return _lenght;}
            set {} 
        }

        public void SetY() 
        {
            // Y axis.
            Console.WriteLine("Пожалуйста, введите координату Y");
            double y;
            if (!Double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Координата Y должна быть числом");
            }
            else 
            {
                this.Y = y;
            }
        }

        public void SetX()
        {
            // X axis.
            Console.WriteLine("Пожалуйста, введите координату X");
            double x;
            if (!Double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Координата X должна быть числом");
            }
            else 
            {
                this.X = x;
            }
        }
    }
}
