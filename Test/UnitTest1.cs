using Xunit;
using Solid;
namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void testCircle()
        {
            Assert.Equal(12.57, new �alculator().calculateAreaCircle(2));
            Assert.Equal(0, new �alculator().calculateAreaCircle(0));

        }
        [Fact]
        public void testTriangle()
        {
            Assert.Equal(1.98, new �alculator().calculateAreaTriangle(3,2,2));
            Assert.Equal(0, new �alculator().calculateAreaTriangle(0, 0, 0));

        }
    }
}