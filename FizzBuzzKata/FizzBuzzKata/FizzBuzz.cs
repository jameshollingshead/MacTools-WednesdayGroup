using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        public string GetFizzBuzz(int input)
        {
            var result = input.ToString();

            if (IsDivisibleBy3(input))
                result = "Fizz";

            if (IsDivisibleBy5(input))
                result = "Buzz";

            if (IsDivisibleBy15(input))
                result = "FizzBuzz";


            return result;
        }

        private static bool IsDivisibleBy15(int input)
        {
            return input % 15 == 0;
        }

        private static bool IsDivisibleBy5(int input)
        {
            return input % 5 == 0;
        }

        private static bool IsDivisibleBy3(int input)
        {
            return input % 3 == 0;
        }
    }
}
