using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewDotNetFrameworkConsoleApp.Scenario1
{
    /*
         * Task 1: Fix the compiler error.
         * Task 2: Fix the logical error. (Expected result value 720)
         * Task 3: Make it an iterative function call.
         * 
         */
    class Program_Scenario1
    {
        /*
        DO NOT FIX ANYTHING HERE
        */
        public static void Main1(string[] args)
        {
            // 6! (factorial) is equal to....
            // 6 * 5 * 4 * 3 * 2 * 1

            var case1 = (6, 720);
            var factorial = GetFactorial(case1.Item1);

            Console.WriteLine($"Expected Factorial of {case1.Item1} is {case1.Item2} | Actual({factorial}) : Test {(case1.Item2 == factorial ? "passed" : "failed") }");


            var case2 = (10, 3628800);
            factorial = GetFactorial(case2.Item1);

            Console.WriteLine($"Expected Factorial of {case2.Item1} is {case2.Item2} | Actual({factorial}) : Test {(case2.Item2 == factorial ? "passed" : "failed") }");
            Console.ReadLine();
        }

        /*
        FIND AND FIX THE PROBLEMS HERE
        */
        private static int GetFactorial(int number)
        {
            int j = 1;
            
            return j;
            // return number * GetFactorial(number - 1);
        }
    }
}
