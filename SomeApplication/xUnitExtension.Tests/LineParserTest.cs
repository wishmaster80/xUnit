using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xUnitExtension.Tests
{
    public class LineParserTest
    {
        private LineParser _lp = new LineParser();

        public static readonly DateTime DateExpected = new DateTime(1900, 1, 1);
        public static readonly DateTime DateTimeExpected = new DateTime(1900, 1, 1, 10, 23, 12);

        [Theory]
        [InlineData("", new object[] { null })]
        [InlineData("int:1", new object[] { 1 })]
        [InlineData("string:A", new object[] {  "A" })]
        [InlineData("int:1|string:A", new object[] { 1, "A" })]
        [InlineData("int:1|int:2", new object[] { 1, 2 })]
        [InlineData("int:1|date:1900-1-1", new object[] { 1, DateExpected })]
        [InlineData("int:1|date:1900-1-1_10:23:12", new object[] { 1, DateTimeExpected })]
        [InlineData("int:1|decimal:2.2", new object[] { 1, 2.2M })]
        public void ResultListShouldBeAsExpected(string line, object[] parametersExpected)
        {
            var result = _lp.ParseLine(line);

            Assert.Equal(parametersExpected, result);
        }

    }
}
