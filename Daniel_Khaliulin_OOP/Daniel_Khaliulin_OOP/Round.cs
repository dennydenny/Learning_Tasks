using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Daniel_Khaliulin_Task3
{
    public class Round
    {   
        // X axis.
        private double _x;
        public double X {
            get {return _x;}
            set
            {
                if (value.Equals(""))
                {
                    value = 0;
                }
                else
                {
                    _x = value;
                }
            }
        }

        // Y axis.
        private double _y;
        public double Y {
            get { return _y; }
            set
            {
                if (value.Equals(""))
                {
                    value = 0;
                }
                else
                {
                    _y = value;
                }
            }
        }

        private double _r;
        public double R
        {
            get {return _r;}
            set
            {
                if (value.Equals(""))
                {
                    value = 0;
                }
                else
                {
                    _r = value;
                }
            }
        }

        public double Lenght { 
            get {
                if (_r == 0)
                {
                    Console.WriteLine("Невозможно вычислить длину окружности при нулевом радиусе. Пожалуйста, задайте радиус");
                    return 0;
                }
                 else
                {
                    return 2 * Math.PI * _r;
                }
            }
        }

        public double S {
            get {
                if (_r == 0)
                {
                    Console.WriteLine("Невозможно вычислить площадь окружности при нулевом радиусе. Пожалуйста, задайте радиус");
                    return 0;
                }
                else
                {
                    return Math.PI * (_r * _r);
                }
            
            } 
            
            }
    }
}
