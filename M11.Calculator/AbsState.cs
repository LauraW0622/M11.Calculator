using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11.Calculator
{
    abstract class AbsState
    {
        public Form1 f1;
        public double val1;
        public double val2;
        public Operator op;

        public abstract AbsState nextState(char digit);

        public abstract AbsState nextState(Operator op); 
        
        public abstract AbsState nextState(ResultState eq);

    }
}
