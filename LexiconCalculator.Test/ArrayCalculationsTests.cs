using Xunit;

namespace LexiconCalculator.Test
{
    public class ArrayCalculationsTest
    {
        [Fact]
        public void AssertArrayAdditionMethodResult()
        {
            //Arrange
            double[] arrayOfDoublesToBeSummed = new double[] { 1, 2, 3, 5, };
            double expectedResult = 11;

            //Act 
            double actualResult = CalculatorProgram.AdditionWithArray(arrayOfDoublesToBeSummed);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(new double[] { 3, 4 }, 7)]
        [InlineData(new double[] {}, 0)]
        [InlineData(new double[] { -1, 1 }, 0)]
        [InlineData(new double[] { 1.2, 4.3 }, 5.5)]
        [InlineData(new double[] { 0, 4 }, 4)]
        public void AssertMultipleArrayAdditionMethodResults(double[] arrayOfDoublesToBeSummed, double expectedResult)
        {
            //Act 
            double actualResult = CalculatorProgram.AdditionWithArray(arrayOfDoublesToBeSummed);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(new double[] { 13, 4, 3, 5 }, 1)]
        [InlineData(new double[] { }, 0)]
        [InlineData(new double[] { -1, 1 }, -2)]
        [InlineData(new double[] { 11.2, 4.3 }, 6.9)]
        [InlineData(new double[] { 0, 4 }, -4)]
        public void AssertMultipleArraySubstractionMethodResults(double[] arrayOfDoublesToBeSubstracted, double expectedResult)
        {
            //Act 
            double actualResult = CalculatorProgram.SubstractionWithArray(arrayOfDoublesToBeSubstracted);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
    
}
