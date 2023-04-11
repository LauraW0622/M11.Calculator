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

        public ResultState(double val1, double val2, Operator op)
        {
            this.val1 = val1;
            this.val2 = val2;
            this.op = op;
        }

        //If CE is pressed, clear the result and remain in same state
        public override AbsState nextState(CE ce)
        {
            val1 = 0;
            f1.displayBox.Text = val1.ToString();
            return this;
        }

        //If digits 0-9 pressed, overwrite the original result and transition to FirstNumberState
        public override AbsState nextState(char digit)
        {
           
            string result = "" + digit; 
            val2 = Double.Parse(result);
            f1.displayBox.Text = val2.ToString();
            return new FirstNumberState(val1, val2, op); 
        }

        //If binary operators (+ - / *) pressed, transition to Operator state (making the result the first number) 
        public override AbsState nextState(Operator op)
        {
            return new OperatorState(val1, val2, op);
        }

        //If a unary operator pressed (sqrt 1/x negation), perform the computation and transition to FirstNumberState
        public override AbsState nextState(Unary uop)
        {
            val1 = uop.perform(val1);
            f1.displayBox.Text = val1.ToString();
            return new FirstNumberState(val1, val2, op);
        }

        //Buttons: = 
        public override AbsState nextState(ResultState eq)
        {
            val1 = op.perform(val1, val2); 
            f1.displayBox.Text = val1.ToString();
            return this; 
        }

        public override AbsState nextState(Decimal dec)
        {
            string result = "0" + ".";
            val2 = Double.Parse(result);
            f1.displayBox.Text = val2.ToString();
            return new FirstNumberState(val1, val2, op);
        }

        public override AbsState nextState(BackSpace backspace)
        {
            return this; 
        }
    }
}
