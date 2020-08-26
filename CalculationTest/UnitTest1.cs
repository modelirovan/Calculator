using CalculationLibrary;
using System.Collections.Generic;
using Xunit;

namespace CalculationTest
{
    public class UnitTest1
    {
        [Fact]
        public void Calculate_RShouldCalculate()
        {
            //Arrange

            var expected = 57;

            //Act
            var listOfParameters = new List<List<int>>()
            {
                new List<int> { 1,78,79,80,81,82,83,84 }
            };

            var result = CalculationService.CalculateR(listOfParameters);
            //Assert

            Assert.Equal(expected, result[0]);
        }

        [Fact]
        public void CalculateMediana_MedianaShouldCalculate()
        {
            //Arrange
            var expected = 6;

            //Act
            var arrayR = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var mediana = CalculationService.CalculateMediana(arrayR);

            //Assert
            Assert.Equal(expected, mediana);
        }
    }
}
