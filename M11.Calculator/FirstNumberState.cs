using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11.Calculator
{
    internal class FirstNumberState : AbsState
    { 
        public FirstNumberState() { }

        public override AbsState nextState(char digit)
        {
            string result = f1.displayBox.Text + digit;
            val1 = Convert.ToDouble(result);
            f1.displayBox.Text = val1.ToString(); 
            return this;
        }

        public override AbsState nextState(Operator op)
        {
            this.op = op;
            val2 = val1;
            return f1.operatorState;
        }

        public override AbsState nextState(ResultState eq)
        {
            val1 = op.perform(val1, val2);
            f1.displayBox.Text = val1.ToString();
            return f1.resultState;
        }
    }
    
}
