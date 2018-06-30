using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MatrixUnitTestProject
{
    [TestClass]
    public class MatrixUnitTest
    {
        [TestMethod]
        public void MultiplyMatriciesTestMethod()
        {
            double[,] firstMatrix = new double[,] { { 1, 1, 1, 1 }, { 2, 2, 2, 2 }, { 3, 3, 3, 3 } };
            double[,] secondMatrix = new double[,] { { 4, 5, 1 }, { 4, 5, 1 }, { 4, 5, 1 }, { 4, 5, 1 } };


            MatrixOperations.Matrix.MatrixOperations matrixObject = new MatrixOperations.Matrix.MatrixOperations();

            double[,] result = matrixObject.Multiply(firstMatrix, secondMatrix);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write("{0} ", result[i, j]);
                }

                Console.WriteLine(Environment.NewLine);
            }

            matrixObject.ShowMatrix(result);

            Assert.AreEqual(16, result[0, 0]);
            Assert.AreEqual(20, result[0, 1]);
            Assert.AreEqual(4, result[0, 2]);
            Assert.AreEqual(32, result[1, 0]);
            Assert.AreEqual(40, result[1, 1]);
            Assert.AreEqual(8, result[1, 2]);
            Assert.AreEqual(48, result[2, 0]);
            Assert.AreEqual(60, result[2, 1]);
            Assert.AreEqual(12, result[2, 2]);
            //16 20 4
            //32 40 8
            //48 60 12

        }
        [TestMethod]
        public void TransposeMatrixTestMethod()
        {
            double[,] firstMatrix = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            MatrixOperations.Matrix.MatrixOperations matrixObject = new MatrixOperations.Matrix.MatrixOperations(firstMatrix);

            double[,] result = matrixObject.Transpose(firstMatrix);

            Console.WriteLine("The source matrix");
            matrixObject.ShowMatrix(firstMatrix);

            Console.WriteLine("The transposed matrix");
            matrixObject.ShowMatrix(result);

            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(4, result[0, 1]);
            Assert.AreEqual(7, result[0, 2]);
            Assert.AreEqual(2, result[1, 0]);
            Assert.AreEqual(5, result[1, 1]);
            Assert.AreEqual(8, result[1, 2]);
            Assert.AreEqual(3, result[2, 0]);
            Assert.AreEqual(6, result[2, 1]);
            Assert.AreEqual(9, result[2, 2]);

            //1 4 7
            //2 5 8
            //3 6 9
        }
        [TestMethod]
        public void DeterminantCalculationTestMethod()
        {
            double[,] firstMatrix = new double[,] { { 1, 2, 0 }, { 3, 2, 1 }, { 0, 1, 2 } };

            MatrixOperations.Matrix.MatrixOperations matrixObject = new MatrixOperations.Matrix.MatrixOperations();

            double result = matrixObject.Determinant(firstMatrix);

            Assert.AreEqual(-9, result);

            Console.WriteLine(" deteminant = {0}", result);
        }

        [TestMethod]
        public void InverseMatrixTestMethod()
        {
            double[,] firstMatrix = new double[,] { { 1, 2, 0 }, { 3, 2, 1 }, { 0, 1, 2 } };

            MatrixOperations.Matrix.MatrixOperations matrixObject = new MatrixOperations.Matrix.MatrixOperations();

            double[,] result = matrixObject.InverseMatrix(firstMatrix);

            Console.WriteLine("It is a source matrix");
            matrixObject.ShowMatrix(firstMatrix);


            Console.WriteLine("It is an inverse matrix");
            matrixObject.ShowMatrix(result);
            //-0.33 1.33 0.00
            //1.33  -0.44 0.11
            //0.00  0.11  0.89


            Assert.AreEqual(-0.33, result[0, 0], 0.1);
            Assert.AreEqual(1.33, result[0, 1], 0.1);
            Assert.AreEqual(0.00, result[0, 2], 0.1);

            Assert.AreEqual(1.33, result[1, 0], 0.1);
            Assert.AreEqual(-0.44, result[1, 1], 0.1);
            Assert.AreEqual(0.11, result[1, 2], 0.1);

            Assert.AreEqual(0.00, result[2, 0], 0.1);
            Assert.AreEqual(0.11, result[2, 1], 0.1);
            Assert.AreEqual(0.89, result[2, 2], 0.1);
        }
    }
}
