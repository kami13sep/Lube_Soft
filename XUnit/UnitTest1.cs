
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace XUnit
{
    //[TestClass]
    public class UnitTest1
    {
      

        //[Fact]
        //public void Test()
        //{ 
        
        //}

        [Fact]
        public void PassingTest()
        {
            Assert.Equals(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equals(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
