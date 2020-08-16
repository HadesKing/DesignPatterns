using Microsoft.VisualStudio.TestTools.UnitTesting;
using Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Tests
{
    [TestClass()]
    public class TestClientTests
    {
        [TestMethod()]
        public void MainTest()
        {
            new TestClient().Main();

            Assert.IsTrue(true);
        }
    }
}