using System;
using Xunit;
namespace Calculations.Test
{
    public class NamesTest
    {
        public NamesTest()
        {
        }

        [Fact]
        public void MakeFullNameTest()
        {
            var names = new Names();
            var result = names.MakeFullName("Aref", "Karimi");
            Assert.Equal("Aref Karimi", result);
        }

        [Fact]
        public void MakeFullNameTestIgnoreCase()
        {
            var names = new Names();
            var result = names.MakeFullName("Aref", "Karimi");
            Assert.Equal("Aref Karimi", result, ignoreCase: true);
        }

        [Fact]
        public void MakeFullNameTestContains()
        {
            var names = new Names();
            var result = names.MakeFullName("Aref", "Karimi");
            Assert.Contains("aref", result, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void MakeFullNameTestStartsWith()
        {
            var names = new Names();
            var result = names.MakeFullName("Aref", "Karimi");
            Assert.StartsWith("Aref", result, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void MakeFiullNameTestEndsWith()
        {
            var names = new Names();
            var result = names.MakeFullName("Aref", "Karimi");
            Assert.EndsWith("rimi", result, StringComparison.InvariantCultureIgnoreCase);
        }

        [Fact]
        public void MakeFiullNameTestMatch()
        {
            var names = new Names();
            var result = names.MakeFullName("Aref", "Karimi");
            Assert.EndsWith("rimi", result, StringComparison.InvariantCultureIgnoreCase);
        }

    }
}
