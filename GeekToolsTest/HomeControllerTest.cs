using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GeekToolsTest
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void PositiveTest()
        {
            //Sample test project
            int x = 7;
            int y = 7;
            Assert.AreEqual(x, y);
        }
    }
}
