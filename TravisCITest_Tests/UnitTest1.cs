using System;
using Xunit;
using TravisCITest;

namespace TravisCITest_Tests
{
    public class TestableFixture
    {
        [Fact]
        public void ReturnsTheSame()
        {
            var sut = new Testable();
            
            Assert.Equal(sut.ReturnSame(5), 5);
        }
    }
}
