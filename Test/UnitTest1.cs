using Xunit;
using Solid;
namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void testCircle()
        {
            Assert.Equal(12.57, new Ñalculator().calculateAreaCircle(2));
            Assert.Equal(0, new Ñalculator().calculateAreaCircle(0));

        }
        [Fact]
        public void testTriangle()
        {
            Assert.Equal(1.98, new Ñalculator().calculateAreaTriangle(3,2,2));
            Assert.Equal(0, new Ñalculator().calculateAreaTriangle(0, 0, 0));

        }
    }
}