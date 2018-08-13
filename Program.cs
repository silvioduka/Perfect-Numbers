/*
Perfect Numbers from Coding Challenges
by Silvio Duka

Last modified date: 2018-04-03 

A perfect number is a positive integer that is equal to the sum of its proper positive divisors, that is, the sum of its positive divisors excluding the number itself. 
The smallest perfect number is 6: its proper divisors are 1, 2, and 3, and 1 + 2 + 3 = 6. 

Write a program which will check if the given input is a perfect number or not. 

For Example: 
Input: 6 
Output: true 

Input: 20 
Output: false 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20; // Insert a number to check
            int sum = 1;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) { sum += i; if (sum > number) break; }                
            }

            Console.WriteLine($"Input: {number}");
            Console.WriteLine($"Output: {((sum == number)?"true":"false")}");
        }
    }
}