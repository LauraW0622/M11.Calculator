using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11.Calculator
{
    internal class SecondNumberState : AbsState
    {
        public SecondNumberState() { }

        public SecondNumberState(double val1, double val2, Operator op)
        {
            this.val1 = val1;
            this.val2 = val2;
            this.op = op;
        }

        //If CE pressed, set the second number to 0 and remain in same state
        public override AbsState nextState(CE ce)
        {
            val2 = 0;
            f1.displayBox.Text = val2.ToString();
            return this;
        }

        //If a digit is pressed, concatenate to the same number
        public override AbsState nextState(char digit)
        {
            string result = f1.displayBox.Text + digit;
            val2 = Double.Parse(result);
            f1.displayBox.Text = val2.ToString();
            return this;
        }

        //If a binary operator is pressed (+ - / *) go to Operator state
        public override AbsState nextState(Operator op)
        {
            val1 = base.op.perform(val1, val2);
            f1.displayBox.Text = "" + val1.ToString();
            return new OperatorState(val1, val2, op);
        }

        //If a unary operator is pressed (sqrt 1/x negation), perform the computation and remain in the same state
        public override AbsState nextState(Unary uop)
        {
            val2 = uop.perform(val2);
            f1.displayBox.Text = val2.ToString();
            return this;
        }

        //If = pressed, perform the operation and transition to ResultState
        public override AbsState nextState(ResultState eq)
        {
            val1 = op.perform(val1, val2);
            f1.displayBox.Text = val1.ToString();
            return new ResultState(val1, val2, op);
        }

        public override AbsState nextState(Decimal dec)
        {
            string number = f1.displayBox.Text;
            foreach (char c in number)
            {
                if (number.Contains('.'))
                {
                    break;
                }
                else
                {
                    number += ".";
                    f1.displayBox.Text = number;
                    number  +=  "0";
                    val2 = Convert.ToDouble(number);
                    

                }

            }
            return this;
        }

        public override AbsState nextState(BackSpace backspace)
        {
            string number = val2.ToString();
            if (number.Length == 1)
            {
                number = "0";
            }
            else
            {
                number = number.Substring(0, number.Length - 1);
                
                
            }
            val2 = Convert.ToDouble(number);
            f1.displayBox.Text = val2.ToString();

            return this;
        }
    }
}
