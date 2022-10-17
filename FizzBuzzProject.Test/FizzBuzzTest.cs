using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzProject.Test
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(75, "FizzBuzz")]
        [InlineData(12, "Fizz")]
        [InlineData(25, "Buzz")]
        [InlineData(32, "Blitz")]

        public void FizzBuzzCalculatorTest(int userInputNumber, string expected)
        {
            //Arrange
            var input = new FizzBuzz();

            //Act
            var actual = input.FizzBuzzCalculator(userInputNumber);

            //Assert
            Assert.Equal(actual, expected);


        }
    }
}
