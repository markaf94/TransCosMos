using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransCosMos
{
    /*
     * This Program prints the output for FizzBuzz from 1 - 100
     * 
     */
    public class Program
    {
        static void Main(string[] args)
        {
            for ( int i = 1; i <= 100; i ++ )
            {
                Console.WriteLine(FizzBuzz(i));
            }
            Console.WriteLine("Press anything to quit");
            Console.ReadKey();
        }

        /*
         * Returns:
         * Fizz, when number can be divided by 3.
         * Buzz, when number can be divided by 5.
         * Fizz Buzz, when number can be divided by 3 and 5.
         * The number, if none of the above cases are true.
         * 
         * Param:
         * Number, the input.
         */
        public static string FizzBuzz(int number)
        {
            string result;

            if(number < 1 || number > 100)
            {
                return result = "Error";
            }

            if (number % 3 == 0 && number % 5 == 0)
            {
                result = "Fizz Buzz";
            }
            else if (number % 3 == 0)
            {
                result = "Fizz";
            }
            else if (number % 5 == 0)
            {
                result = "Buzz";
            }
            else
            {
                result = number.ToString();
            }

            return result;
        }
    }
}
