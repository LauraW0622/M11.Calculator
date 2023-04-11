using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11.Calculator
{
    internal class Sqrt : Unary
    {
        public override double perform(double v1)
        {
            return Math.Sqrt(v1);
        }
    }
}
