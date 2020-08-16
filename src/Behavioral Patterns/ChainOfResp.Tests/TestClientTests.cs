using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChainOfResp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResp.Tests
{
    [TestClass()]
    public class TestClientTests
    {
        [TestMethod()]
        public void MainTest()
        {
            TestClient test = new TestClient();
            test.Main();

            Assert.IsTrue(true);
            //Assert.Fail();
        }
    }
}