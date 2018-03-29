using System;
using System.Collections.Generic;

namespace FizzBuzz.Library
{
    public class FizzBuzzService
    {
        public string Print(int number)
        {
            if (IsDivisibleBy3(number) && IsDivisibleBy5(number))
            {
                return "FizzBuzz";
            }
            else if (IsDivisibleBy5(number))
            {
                return "Buzz";
            }
            else if (IsDivisibleBy3(number))
            {
                return "Fizz";
            }
            else
            {
                return number.ToString();
            }
        }

        private bool IsDivisbleBy3(int number)
        {
            return number % 3 == 0;
        }

        private bool IsDivisbleBy5(int number)
        {
            return number % 5 == 0;
        }
    }
}