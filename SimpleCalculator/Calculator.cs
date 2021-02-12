using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    // creation of abstract class
  public abstract class Calculator
    {
        protected int Num1 { get; set; }
        protected int Num2 { get; set; }
        public Calculator(int a, int b)
        {
            Num1 = a;
            Num2 = b;
        }
        // creation of an abstract method
        public abstract int Result();
        
    }
}
