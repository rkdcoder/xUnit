namespace Calculations.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_Given1And2_Returns3()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var sum = calculator.Add(1,2);

            // Assert

            Assert.Equal(3, sum);
        }

        [Fact]
        public void Add_GivenTwoDecimals_ReturnsSumWithTwoPlaces()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var sum = calculator.Add(2.643m, 3.323m); // the method Add decimals rounds with two decimal places, so, the result is 5.97

            // Assert

            Assert.Equal(5.97m, sum, 2);
        }
    }
}
