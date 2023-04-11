using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11.Calculator
{
    internal class Negation : Unary
    {
        public override double perform(double v)
        {
            if (v == 0)
            {
                return 0; 
            }
            else
                return v * -1;
        }
    }
}
