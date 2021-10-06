using Xunit;

namespace LexiconCalculator.Test
{
    public class BasicCalculationsTests
    {
        [Fact]
        public void AssertAdditionMethodResult()
        {
            //Arrange
            double inputNumberOne = 3;
            double inputNumberTwo = 4;
            double expectedResult = 7;

            //Act 
            double actualResult = CalculatorProgram.Addition(inputNumberOne, inputNumberTwo);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(3, 4, 7)]
        [InlineData(5, -5, 0)]
        [InlineData(-1, -1, -2)]
        [InlineData(3.1, 4.1, 7.20)]
        [InlineData(5.2, -5.2, 0)]
        [InlineData(-1.3, -1.3, -2.60)]
        public void AssertMultipleAdditionMethodResults(double inputNumberOne, double inputNumberTwo, double expectedResult)
        {
            //Act 
            double actualResult = CalculatorProgram.Addition(inputNumberOne, inputNumberTwo);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Theory]
        [InlineData(3, 4, -1)]
        [InlineData(5, -5, 10)]
        [InlineData(-1, -1, 0)]
        [InlineData(3.1, 4.1, -1)]
        [InlineData(5.2, -5.2, 10.40)]
        [InlineData(-1.3, -1.3, 0)]
        public void AssertMultipleSubstractionMethodResults(double inputNumberOne, double inputNumberTwo, double expectedResult)
        {
            //Act 
            double actualResult = CalculatorProgram.Substraction(inputNumberOne, inputNumberTwo);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(3, 4, 12)]
        [InlineData(5, -5, -25)]
        [InlineData(-1, -1, 1)]
        [InlineData(3.1, 4.1, 12.71)]
        [InlineData(5.2, -5.2, -27.04)]
        [InlineData(-1.3, -1.3, 1.69)]
        public void AssertMultipleMultiplicationMethodResults(double inputNumberOne, double inputNumberTwo, double expectedResult)
        {
            //Act 
            double actualResult = CalculatorProgram.Multiplication(inputNumberOne, inputNumberTwo);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Theory]
        [InlineData(3, 4, 0.75)]
        [InlineData(5, -5, -1)]
        [InlineData(-1, -1, 1)]
        [InlineData(3.1, 4.1, 0.76)]
        [InlineData(5.2, -5.2, -1)]
        [InlineData(-1.3, -1.3, 1)]
        [InlineData(4, 0, 0)]
        [InlineData(0, 4, 0)]
        public void AssertMultipleDivisionMethodResults(double inputNumberOne, double inputNumberTwo, double expectedResult)
        {
            //Act 
            double actualResult = CalculatorProgram.Division(inputNumberOne, inputNumberTwo);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
