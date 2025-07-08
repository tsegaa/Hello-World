using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLib;

namespace MathLibTests
{
    [TestClass]
    public class MathOperationsTests
    {
        [TestMethod]
        public void Add_ReturnsSum()
        {
            Assert.AreEqual(5, MathOperations.Add(2, 3));
        }

        [TestMethod]
        public void Divide_ByZero_ReturnsNull()
        {
            Assert.IsNull(MathOperations.Divide(10, 0));
        }
    }
}
