using System;
using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kaffeTests
{
    [TestClass]
    public class FlatWhiteTests
    {
        [TestMethod]
        public void TestStyrke()
        {
            var fw = new FlatWhite();
            Assert.AreEqual("Mild", fw.Styrke());
        }

        [TestMethod]
        public void TestPris()
        {
            var fw = new FlatWhite();
            Assert.AreEqual(45, fw.Pris());
        }

        [TestMethod]
        public void TestMlMælk()
        {
            var fw = new FlatWhite();
            Assert.AreEqual(160, fw.MlMælk());
        }
    }
}
