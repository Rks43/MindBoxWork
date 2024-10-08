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
            Assert.Equal(0, new Ņalculator().calculateAreaCircle(0));

        }
        [Fact]
        public void testTriangle()
        {
            Assert.Equal(1.98, new Ņalculator().calculateAreaTriangle(3,2,2));
            Assert.Equal(0, new Ņalculator().calculateAreaTriangle(0, 0, 0));

        }
        [Fact]
        public void testSquareness()
        {
            Assert.Equal(true, new Ņalculator().checkSquareness(3, 4, 5));
            Assert.Equal(false, new Ņalculator().checkSquareness(3, 4, 6));
        }
    }
}