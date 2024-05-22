using System;
using Xunit;

namespace Calculator_OOP
{
    public class CalcTests
    {
        private Calc calculator;

        public CalcTests()
        {
            calculator = new Calc();
        }

        [Fact]
        public void Add_PositiveNumber_CorrectResult()
        {
            // Arrange
            var calculator = new Calc();
            double num1 = 5;
            double num2 = 3;

            // Act
            double result = calculator.Add(num1, num2);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_NegativeNumbers_CorrectResult()
        {
            // Arrange
            double num1 = -5;
            double num2 = -3;

            // Act
            double result = calculator.Add(num1, num2);

            // Assert
            Assert.Equal(-8, result);
        }

        [Fact]
        public void Add_DecimalNumbers_CorrectResult()
        {
            // Arrange
            double num1 = 5.5;
            double num2 = 3.3;

            // Act
            double result = calculator.Add(num1, num2);

            // Assert
            Assert.Equal(8.8, result, 2); // Precision of 2 decimal places
        }

        [Fact]
        public void Subtract_PositiveNumber_CorrectResult()
        {
            // Arrange
            double num1 = 5;
            double num2 = 3;

            // Act
            double result = calculator.Subtract(num1, num2);

            // Assert
            Assert.Equal(2, result); // Precision of 2 decimal places
        }
        [Fact]
        public void Subtract_NegativeNumbers_CorrectResult()
        {
            // Arrange
            double num1 = -5;
            double num2 = -3;

            // Act
            double result = calculator.Subtract(num1, num2);

            // Assert
            Assert.Equal(-2, result);
        }

        [Fact]
        public void Subtract_DecimalNumbers_CorrectResult()
        {
            // Arrange
            double num1 = 5.5;
            double num2 = 3.3;

            // Act
            double result = calculator.Subtract(num1, num2);

            // Assert
            Assert.Equal(2.2, result, 2); // Precision of 2 decimal places
        }
        [Fact]
        public void Multiply_PositiveNumber_CorrectResult()
        {
            // Arrange
            double num1 = 5;
            double num2 = 3;

            // Act
            double result = calculator.Multiply(num1, num2);

            // Assert
            Assert.Equal(15, result); // Precision of 2 decimal places
        }
        [Fact]
        public void Multiply_NegativeNumbers_CorrectResult()
        {
            // Arrange
            double num1 = -5;
            double num2 = -3;

            // Act
            double result = calculator.Multiply(num1, num2);

            // Assert
            Assert.Equal(-15, result);
        }

        [Fact]
        public void Multiply_DecimalNumbers_CorrectResult()
        {
            // Arrange
            double num1 = 5.5;
            double num2 = 3.3;

            // Act
            double result = calculator.Multiply(num1, num2);

            // Assert
            Assert.Equal(2.2, result, 2); // Precision of 2 decimal places
        }
        [Fact]
        public void Divide_PositiveNumber_CorrectResult()
        {
            // Arrange
            double num1 = 5;
            double num2 = 3;

            // Act
            double result = calculator.Divide(num1, num2);

            // Assert
            Assert.Equal(1.66666666666667, result); // Precision of 2 decimal places
        }
        [Fact]
        public void Divide_NegativeNumbers_CorrectResult()
        {
            // Arrange
            double num1 = -5;
            double num2 = -3;

            // Act
            double result = calculator.Divide(num1, num2);

            // Assert
            Assert.Equal(-1.66666666666667, result);
        }

        [Fact]
        public void Divide_DecimalNumbers_CorrectResult()
        {
            // Arrange
            double num1 = 5.5;
            double num2 = 3.3;

            // Act
            double result = calculator.Divide(num1, num2);

            // Assert
            Assert.Equal(1.66666666666667, result); // Precision of 2 decimal places
        }
    }
}