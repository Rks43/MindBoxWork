using Xunit;
using Solid;
namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void testCircle()
        {
            Assert.Equal(12.57, new Ņalculator().calculateAreaCircle(2));
        }
        [Fact]
        public void testTriangle()
        {
            Assert.Equal(1.98, new Ņalculator().calculateAreaTriangle(3,2,2));
        }
    }
}