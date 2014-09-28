using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryToDecimal;

namespace BinaryToDecimalUnitTest
{
    [TestClass]
    public class BinToDecTest
    {
        [TestMethod]
        public void NormalMethod()
        {
            int result = ConvertBinaryToDecimal.BinaryToDecimal("101");
            Assert.AreEqual(5, result);
        }
        [TestMethod]
        public void ZeroMethod()
        {
            int result = ConvertBinaryToDecimal.BinaryToDecimal("00000000");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void OneMethod()
        {
            int result = ConvertBinaryToDecimal.BinaryToDecimal("00000001");
            Assert.AreEqual(1, result);
        }
        
    }
}
