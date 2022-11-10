
using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calculator=new Calculator();

            var actual=calculator.Add(num1, num2, num3);

            Assert.Equal(expected, actual);

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,2,1)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calc = new Calculator();


            //Act
            var total=calc.substract(minuend, subtrhend);

            
            //Assert
            Assert.Equal(expected, total);
        }

        [Theory]
        [InlineData(3,4,12)]
        [InlineData(3,8,24)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var calc = new Calculator();

            //Act

            var total = calc.mult(num1, num2);

            //Assert
            Assert.Equal(expected, total);
        }

        [Theory]
        [InlineData(4,2,2)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            Calculator calc = new Calculator();

            //Act
           int total= calc.div(num1, num2);

            //Assert
            Assert.Equal(expected, total);
       
        }

    }
}
