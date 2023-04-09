using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11.Calculator
{
    internal class Add : Operator
    {
        public override double perform(double v1, double v2)
        {
            return v1 + v2;
        }
    }
}
