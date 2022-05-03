using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NQueensTests
{
    [TestClass]
    public class NQueenUnitTest
    {
        [TestMethod]
        public void TestIfQueenIsValid()
        {
            var test = new SolveNQueens.SolveNQueens(3);
            int[] testBoard = { 2, 0, 0, 0 };
            bool result = test.IsSafe(testBoard, 2, 3);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIfQueenIsInvalid()
        {
            var test = new SolveNQueens.SolveNQueens(3);
            int[] testBoard = { 2, 0, 0, 0 };
            bool result = test.IsSafe(testBoard, 2, 2);

            Assert.IsFalse(result);
        }
    }
}