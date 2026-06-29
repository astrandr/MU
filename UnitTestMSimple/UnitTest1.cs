using Microsoft.VisualStudio.TestTools.UnitTesting;
using MUtils;

namespace MUtils.Tests
{
    [TestClass]
    public class MSimpleTests
    {
        [TestMethod]
        public void Add_ReturnsCorrectSum_ForPositiveNumbers()
        {
            var simple = new MSimple();
            double result = simple.Add(2.5, 3.5);
            Assert.AreEqual(6.7, result, 1e-10);
        }

        [TestMethod]
        public void Add_ReturnsCorrectSum_ForNegativeNumbers()
        {
            var simple = new MSimple();
            double result = simple.Add(-2.0, -3.0);
            Assert.AreEqual(-5.0, result, 1e-10);
        }

        [TestMethod]
        public void Add_ReturnsCorrectSum_ForMixedNumbers()
        {
            var simple = new MSimple();
            double result = simple.Add(-2.0, 3.0);
            Assert.AreEqual(1.0, result, 1e-10);
        }

        [TestMethod]
        public void Add_ReturnsCorrectSum_WhenAddingZero()
        {
            var simple = new MSimple();
            double result = simple.Add(0.0, 5.0);
            Assert.AreEqual(5.0, result, 1e-10);
        }
    }
}
