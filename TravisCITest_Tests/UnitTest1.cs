using System;
using TravisCITest;
using Xunit;

namespace TravisCITest_Tests
{
    public class TestableFixture
    {
        [Fact]
        public void ReturnsTheSame()
        {
            var sut = new Testable();

            Assert.Equal(sut.ReturnSame(5), 4);
        }
    }
}
