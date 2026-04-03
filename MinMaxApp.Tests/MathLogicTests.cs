using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinMaxApp; 

namespace MinMaxApp.Tests
{
    [TestClass]
    public class MathLogicTests
    {
        private MathLogic _logic;

        [TestInitialize]
        public void Setup()
        {
            _logic = new MathLogic();
        }

        [TestMethod]
        public void Calculate_FindMax_PositiveNumbers_ReturnsCorrect()
        {
            double result = _logic.Calculate(1.5, 5.2, 3.8, true);
            Assert.AreEqual(5.2, result);
        }

        [TestMethod]
        public void Calculate_FindMin_NegativeNumbers_ReturnsCorrect()
        {
            double result = _logic.Calculate(-10, -50, -2, false);
            Assert.AreEqual(-50, result);
        }

        [TestMethod]
        public void Calculate_FindMax_MixedNumbers_ReturnsCorrect()
        {
            double result = _logic.Calculate(0, -5.5, -1.2, true);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Calculate_FindMin_EqualNumbers_ReturnsCorrect()
        {
            double result = _logic.Calculate(4.4, 4.4, 4.4, false);
            Assert.AreEqual(4.4, result);
        }

        [TestMethod]
        public void Calculate_FindMax_LargeNumbers_ReturnsCorrect()
        {
            double result = _logic.Calculate(999999.9, 1.1, -999999.9, true);
            Assert.AreEqual(999999.9, result);
        }
    }
}