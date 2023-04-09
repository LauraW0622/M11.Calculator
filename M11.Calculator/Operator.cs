using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11.Calculator
{
    abstract class Operator
    {
        public abstract double perform(double v1, double v2); 
    }
}
