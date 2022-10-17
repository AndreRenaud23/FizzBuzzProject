using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzProject;

public class FizzBuzz
{

    public string FizzBuzzCalculator(double userInputNumber)
    {
        if (userInputNumber % 3 == 0 && userInputNumber % 5 == 0)
        {
            return "FizzBuzz";
        }

        if (userInputNumber % 3 == 0)
        {
            return "Fizz";
        }

        if (userInputNumber % 5 == 0)
        {
            return "Buzz";
        }

        if (userInputNumber % 3 != 0 || userInputNumber % 5 != 0)
        {
            return "Blitz";
        }

        return "This is not supposed to be seen!";
    }

}

