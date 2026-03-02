using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Divide_ValidMatrixAndNum_ReturnsDividedMatrix()
        {
            int[,] matrix = { { 4, 8 }, { 12, 16 } };
            int[,] expected = { { 2, 4 }, { 6, 8 } };
            int[,] result = Matrix.Divide(matrix, 2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_NumIsZero_PrintsMessageAndReturnsNull()
        {
            int[,] matrix = { { 1, 2 }, { 3, 4 } };
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                var result = Matrix.Divide(matrix, 0);
                Assert.IsNull(result);
                Assert.IsTrue(sw.ToString().Contains("Num cannot be 0"));
            }
        }

        [Test]
        public void Divide_MatrixIsNull_ReturnsNull()
        {
            int[,] result = Matrix.Divide(null, 2);
            Assert.IsNull(result);
        }

        [Test]
        public void Divide_NegativeNumbers_WorksCorrectly()
        {
            int[,] matrix = { { -6, 6 }, { 9, -9 } };
            int[,] expected = { { -3, 3 }, { 4, -4 } };
            int[,] result = Matrix.Divide(matrix, 2);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Divide_EmptyMatrix_ReturnsEmptyMatrix()
        {
            int[,] matrix = new int[0, 0];
            int[,] result = Matrix.Divide(matrix, 2);
            Assert.AreEqual(0, result.GetLength(0));
            Assert.AreEqual(0, result.GetLength(1));
        }
    }
}