using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    // inheritance from parent class
  public class Division : Calculator
    {

        private int answer;
        // creation of constructor
        public Division(int a, int b, int c) : base(a,b)
        {
            answer = c;
        }
        // provide the quotient 
        public override int Result()
        {
            // TRY. Catch function is my way to avoid the exceptiondivisionbyzero to close the app
           
                try
                {
                    answer = Num1 / Num2;
                }
                catch
                {
                    Console.WriteLine("division by zero");
                }

            if (Num2 != 0)
            {
                Console.Write($"{Num1} / {Num2} = ");
                return answer;
            }
            return -1;

        }
    }
}
