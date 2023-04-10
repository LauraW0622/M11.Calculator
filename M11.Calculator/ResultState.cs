using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11.Calculator
{
    internal class ResultState : AbsState
    {
        public ResultState() { }

        public override AbsState nextState(char digit)
        {
            string result = "" + digit; 
            val1 = Double.Parse(result);
            f1.displayBox.Text = val1.ToString();
            return new FirstNumberState(); 
        }

        public override AbsState nextState(Operator op)
        {
            this.op = op;
            val2 = val1;
            return new OperatorState();
        }

        public override AbsState nextState(ResultState eq)
        {
            val1 = op.perform(val1, val2); 
            f1.displayBox.Text = val1.ToString();
            return this; 
        }
    }
}
