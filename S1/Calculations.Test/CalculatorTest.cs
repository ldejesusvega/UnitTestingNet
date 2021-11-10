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
            Assert.Equal(2, 2); // Wrong

            //Assert.Equal({Expected Value }, { Actual Value});
        }

        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calc = new Calculator();
            var result = calc.Add(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.23, 3.51);
            // Assert Numeric Values 
            //Assert.Equal(4.7, result); // compare result complete
            // To round number amd test result add length to compare
            Assert.Equal(4.6, result, 0); // Compara solo la parte entera


            Assert.Equal(4.7, result, 1); // Compara basado en redonde de 1 digito
        }

        [Fact]
        public void Add_GivenTwoDoubleValues_ReturnsDouble_CompareUnits()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.23, 3.51);
            // Assert Numeric Values 
            //Assert.Equal(4.7, result); // compare result complete
            // To round number amd test result add length to compare
            Assert.Equal(4.7, result, 0); // Compara solo la parte entera
        }


        [Fact]
        public void Add_GivenTwoDoubleValues_ReturnsDouble_OneDigitRound()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.23, 3.51);
            // Assert Numeric Values 
            //Assert.Equal(4.7, result); // compare result complete
            // To round number amd test result add length to compare
            // Only compares 4.7 instead result 4.74
            Assert.Equal(4.7, result, 1); // Compara basado en redonde de 1 digito
        }

    }
}
