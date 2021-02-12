using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    // inheritance from parent class
   public class Multiplication : Calculator
    {
      
        // creation of constructor

        public Multiplication(int a, int b): base(a,b)
        { }
        // provide the product
        public override int Result()
        {
            return Num1 * Num2;
        }
    }
}
