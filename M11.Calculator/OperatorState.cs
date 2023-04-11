using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11.Calculator
{
    internal class OperatorState : AbsState
    {
        public OperatorState() { }

        public OperatorState(double val1, double val2, Operator op)
        {
            this.val1 = val1;
            this.val2 = val2;
            this.op = op;
        }

        public override AbsState nextState(CE ce)
        {
            f1.displayBox.Text = "0";
            return this;
        }

        public override AbsState nextState(char digit)
        {
            string result = "" + digit;
            val2 = Double.Parse(result);
            f1.displayBox.Text = val2.ToString();
            return new SecondNumberState(val1, val2, op);  
        }

        public override AbsState nextState(Operator op)
        {
            this.op = op; 
            return this;
        }

        public override AbsState nextState(Unary uop)
        {
            val2 = uop.perform(val1);
            f1.displayBox.Text = val2.ToString();
            return this;
            //return new ResultState(val1, val2, uop);
        }

        public override AbsState nextState(ResultState eq)
        {
            val2 = val1; 
            val1 = op.perform(val1, val2); 
            f1.displayBox.Text = val1.ToString();
            return new ResultState(val1, val2, op); 
        }

        public override AbsState nextState(Decimal dec)
        {
            string result = "0" + ".";
            f1.displayBox.Text = result;
            result += "0";
            val2 = Double.Parse(result);            
            return new SecondNumberState(val1, val2, op);
           
        }
        public override AbsState nextState(BackSpace backspace)
        {
            return this; 
        }
    }
}
