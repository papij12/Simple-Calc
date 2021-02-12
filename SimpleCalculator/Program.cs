using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
                {
                Console.Clear();
                Console.WriteLine("enter two numbers");
                // initialization of numbers
                int val1 = int.Parse(Console.ReadLine());
                int val2 = int.Parse(Console.ReadLine());

                // creation of object
                var add = new Addition(val1, val2);
                var sub = new Substraction(val1, val2);
                var mult = new Multiplication(val1, val2);
                var div = new Division(val1, val2,0);

                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Divsion");
                Console.WriteLine("4.Multiplication");
                int c = Convert.ToInt16(Console.ReadLine());
                // case that calls the methods using objects created
                switch (c)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"{val1} + {val2} = " + add.Result());
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"{val1} - {val2} = " + sub.Result());
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(div.Result());
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine($"{val1} * {val2} = " + mult.Result());
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Choose Only 1 To 6 ");
                        break;
                }
                Console.WriteLine(" PRESS ESC TO CLOSE THE APP ");
            } while (Console.ReadKey().Key != ConsoleKey.Escape );



        }
    }
}
