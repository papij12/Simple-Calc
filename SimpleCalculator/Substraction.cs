using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    // inheritance from parent class
   public class Substraction : Calculator
    {
        // creation of constructor
        public Substraction(int a, int b) :base(a,b)
        { }
        //provide the difference 
        public override int Result()
        {
            return (Num1 - Num2);
        }
    }
}
