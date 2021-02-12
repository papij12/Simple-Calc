using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    // inheritance from parent class
   public class Addition : Calculator
    {
        // creation of constructor
        public Addition(int a, int b) : base(a,b)
        { }
        // provide the sume  
        public override int Result()
        {
            return (Num1 + Num2);
        }
    }
}
