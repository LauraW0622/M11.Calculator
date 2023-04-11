using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11.Calculator
{
    internal class FirstNumberState : AbsState
    { 
        public FirstNumberState() { }

        
        public FirstNumberState(double val1, double val2, Operator op)
        {
            this.val1 = val1;
            this.val2 = val2;
            this.op = op;
        }


        //If CE pressed in FirstNumberState, clear the first number and remain in the same state
        public override AbsState nextState(CE ce)
        {
            val1 = 0;
            f1.displayBox.Text = val1.ToString();
            return this;
        }

        //If any of the 10 digits pressed in FirstNumberState, concatenate the digit to the same number
        public override AbsState nextState(char digit)
        {
           
            string result = f1.displayBox.Text + digit;
            val1 = Convert.ToDouble(result);
            f1.displayBox.Text = val1.ToString(); 
            return this;
        }

        //If any of the 4 binary operators (+ - / *) pressed, transition to Operator state 
        public override AbsState nextState(Operator op)
        {
            base.op = op;
      
            return new OperatorState(val1, val2, op);
        }

        //If any of the 3 unary operators (1/x negation sqrt) are pressed, perform the required computation and remain in same state
        public override AbsState nextState(Unary uop)
        {
            val1 = uop.perform(val1);
            f1.displayBox.Text = val1.ToString();
            return this;
        }

        //If = pressed, display the result and go to ResultState
        public override AbsState nextState(ResultState eq)
        {  
            f1.displayBox.Text = val1.ToString();
            return new ResultState(val1, val2, op);
        }

        public override AbsState nextState(Decimal dec)
        {
            string number = f1.displayBox.Text;  
            foreach(char c in number)
            {
                if (number.Contains('.')){
                    break;
                }
                else {
                    number += ".";
                    f1.displayBox.Text = number;
                    number  += "0";
                    val1 = Convert.ToDouble(number);
                    Debug.WriteLine(val1);
                }

            }
            return this;
        }

        public override AbsState nextState(BackSpace backspace)
        {
            string number = val1.ToString();
            if (number.Length == 1)
            {
                number = "0";
            }
            else
            {
                number = number.Substring(0, number.Length - 1);
            }
            val1 = Convert.ToDouble(number);
            f1.displayBox.Text = val1.ToString(); 
            return this; 
        }
    }
    
}
