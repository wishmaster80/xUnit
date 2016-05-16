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

        
        [Theory]
        [InlineData("", new object[] { null })]
        [InlineData("int:1", new object[] { 1 })]
        [InlineData("string:A", new object[] {  "A" })]
        [InlineData("int:1|string:A", new object[] { 1, "A" })]
        [InlineData("int:1|int:2", new object[] { 1, 2 })]
        public void ResultListShouldBeAsExpected(string line, object[] parametersExpected)
        {
            var result = _lp.ParseLine(line);

            Assert.Equal(parametersExpected, result);
        }

    }
}
