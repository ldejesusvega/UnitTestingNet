using System;
using Xunit;
using Xunit.Sdk;

namespace Calculations.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            Assert.Equal(2, 2);

            //Assert.Equal({Expected Value }, { Actual Value});
        }

        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calc = new Calculator();
            var result = calc.Add(1, 2);
            // Equal({Expected Value }, { Actual Value})
            // Equal compares this two values, throws EqualException when object are not equal.  
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.23, 3.51);
            // Assert Numeric Values, this compare based on addition result
            // Equal({Expected Value }, { Actual Value})
            // Equal compares this two values, throws EqualException when object are not equal.
            Assert.Equal(4.74, result);
        }

        [Fact]
        public void Add_GivenTwoDoubleValues_ReturnsDouble_CompareUnits()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.23, 3.51);
            // Assert Numeric Values 
            // Equal (decimal expected, decimal actual, int precision);
            // decimal expected, this is the value we expected from test
            // decimal actual, this is the value we get from execute method
            // int precision, this will be decimal positions to compare values
            // int this case precision is zero, only evaluates units from value 
            Assert.Equal(4.7, result, 0); // Compara solo la parte entera
        }

        [Fact]
        public void Add_GivenTwoDoubleValues_ReturnsDouble_OneDigitRound()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.23, 3.51);
            // Assert Numeric Values 
            // Equal (decimal expected, decimal actual, int precision);
            // decimal expected, this is the value we expected from test
            // decimal actual, this is the value we get from execute method
            // int precision, this will be decimal positions to compare values
            // int this case precision is one position, this will compare value
            // with one position after decimal point.
            Assert.Equal(4.7, result, 1);
        }

        [Fact]
        public void Add_GivenTwoDoubleValues_ReturnsDouble_TwoDigitRound()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.23, 3.51);
            // Assert Numeric Values 
            // Equal (decimal expected, decimal actual, int precision);
            // decimal expected, this is the value we expected from test
            // decimal actual, this is the value we get from execute method
            // int precision, this will be decimal positions to compare values
            // int this case precision is two positions, this will compare value
            // with two positions after decimal point.
            Assert.Equal(4.74, result, 2);
        }

    }
}
