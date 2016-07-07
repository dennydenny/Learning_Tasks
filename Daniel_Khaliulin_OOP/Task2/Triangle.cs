using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Triangle
    {
        private double _a;
        public double a { 
            get 
            {
                return _a;
            }
            set 
            {
                _a = value;
            }
        }

        private double _b;
        public double b
        {
            get
            {
                return _b;
            }
            set
            {
                    _b = value;
            }
        }

        private double _c;
        public double c
        {
            get
            {
                return _c;
            }
            set
            {
                    _c = value;
            }
        }


        // Perimetr.
        private double _p;
        public double P
        {
            get
            {
                _p = _a + _b + _c;
                return _p;
            }
        }

        // Calculate S using Heron's Formula (https://ru.wikipedia.org/wiki/%D0%A4%D0%BE%D1%80%D0%BC%D1%83%D0%BB%D0%B0_%D0%93%D0%B5%D1%80%D0%BE%D0%BD%D0%B0).
        public double S
        {
            get
            {
                // In Heron's Formula we need to use semi perimetr.
                double _p2 = _p / 2;
                return Math.Sqrt(_p2 * (_p2 - _a) * (_p2 - _b) * (_p2 - _c));
            }
        }

        // Checking Triangle inequality (https://en.wikipedia.org/wiki/Triangle_inequality). Each side of the triangle should be less than the sum of the other two sides.
        public bool isSidesCorrect 
        {
            get {
                if ((_a < _b + _c) && (_b < _a + _c) && (_c < _a + _b))
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            
            }
        }
    }
}
