using System;
using Xunit;
using IOTest2;

namespace XUnitIOTest2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            CRect cRect = new CRect(2, 3);
            int area = cRect.Area();
            Assert.Equal(7, area);
        }
    }
}
