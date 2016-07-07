using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class Ring : Round 
    {
        // Because ring have 2 radius, SmallR will be small radius, R will be large radius.
        private double _smallr;
        public double SmallR
        {
            get { return _smallr; }
            set
            {
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Радиус должен быть больше нуля");
                    }
                    // Check is radius of small circle really less then radius of large circle.
                    if (value >= this.R)
                    {
                        Console.WriteLine("Радиус малой окружности должен быть меньше, чем радиус большей.");
                    }
                    else
                    {
                        this._smallr = value;
                    }
                }
            }
        }

        public void SetSmallR()
        {
            // Radius.
            Console.WriteLine("Пожалуйста, введите малый радиус");
            double r;
            if (!Double.TryParse(Console.ReadLine(), out r))
            {
                Console.WriteLine("Радиус должен быть числом");
            }
            else
            {
                this.SmallR = r;
            }
        }

        private double _smallLenght;
        public double SmallLenght
        {
            get { return _smallLenght; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Длина должна быть больше нуля");
                }

                // Check is lenght of small circle really less then lenght of large circle.
                if (value >= this.Lenght)
                {
                    Console.WriteLine("Длина малой окружности должна быть меньше, чем длина большей.");
                }
                else
                {
                    this._smallLenght = value;
                }
            }
        }

        public void SetSmallLenght()
        {
            Console.WriteLine("Пожалуйста, введите длину малой окружности");
            double l;
            if (!Double.TryParse(Console.ReadLine(), out l))
            {
                Console.WriteLine("Длина должна быть числом");
            }
            else
            {
                this.SmallLenght = l;
            }
        }

        public double SmallS
        {
            get
            {
                return 2 * Math.PI * (this.SmallR * this.SmallR);
            }
        }
    }
}
