﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M11.Calculator
{
    internal class OperatorState : AbsState
    {
        public OperatorState() 
        {
            this.f1 = base.f1;
        }

        public override AbsState nextState(char digit)
        {
            string result = "" + digit;
            val2 = Double.Parse(result);
            f1.displayBox.Text = val2.ToString();
            return f1.secondNumState; 
        }

        public override AbsState nextState(Operator op)
        {
            this.op = op; 
            return this;
        }

        public override AbsState nextState(ResultState eq)
        {
            val1 = op.perform(val1, val2); 
            f1.displayBox.Text = val1.ToString();
            return f1.resultState; 
        }
    }
}
