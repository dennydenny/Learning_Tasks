using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    class Round : Circle
    {
        public double S {
            get 
            {
                return 2 * Math.PI * (this.R * this.R);
            }
        }
    }
}
