using Xunit;
using Solid;
namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(12.56, new Ñalculator().calculateAreaCircle(2));
        }
    }
}