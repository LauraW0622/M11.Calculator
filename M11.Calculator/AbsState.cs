using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11.Calculator
{
    abstract class AbsState
    {
        public static Form1 f1;
        public double val1; //first number
        public double val2; //second number
        public Operator op; //the operator that was clicked 
        public Unary uop;

        public AbsState()
        {

        }

        //Button pressed -  C: clear the input
        public AbsState nextState(C c)
        {
            f1.displayBox.Text = "0";
            return new FirstNumberState();
        }

        //Button pressed - CE: clear the current number
        public abstract AbsState nextState(CE ce);

        //Button pressed . : add decimal 
        public abstract AbsState nextState(Decimal dec);

        //Buttons pressed:  0-9
        public abstract AbsState nextState(char digit);

        //Buttons pressed:  Binary Operators + - / * 
        public abstract AbsState nextState(Operator op);

        //Buttons pressed: Unary Operators sqrt 1/x negation 
        public abstract AbsState nextState(Unary uop);

        public abstract AbsState nextState(ResultState eq);

        public abstract AbsState nextState(BackSpace backspace); 



    }
}
