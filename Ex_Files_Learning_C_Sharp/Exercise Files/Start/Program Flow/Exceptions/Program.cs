using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1000;
            int y = 0;
            int result;

            // TODO: try-catch expressions make error checking easier
            try {
                if (x > 1000){
                    throw new ArgumentOutOfRangeException("x", "x must be 1000 or less.");
                }
                result = x / y;
                Console.WriteLine("The result is: {0}", result);               
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("You just tried to divide by zero! Please enter a non-zero integer.");
                Console.WriteLine(e.Message);
                try{
                    y = Int32.Parse(Console.ReadLine());
                    result = x / y;
                    Console.WriteLine("The result is: {0}", result);
                }
                catch{
                    Console.WriteLine("That's still not an appropriate integer... I give up.");
                }
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine("Sorry. 1000 is the limit.");
                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine("Thanks for playing!");
            }

        }
    }
}
