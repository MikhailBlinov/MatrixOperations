using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations.Matrix
{
    public class Matrix : ICalculation
    {
        private double[,] _firstMatrix;
        private double[,] _secondMatrix;
        private double[,] _resultMatrix = null;

        public double[,] ResultMatrix => _resultMatrix;

        public Matrix()
        {
        }

        public Matrix(double[,] firstMatrix)
        {
            _firstMatrix = firstMatrix;
        }

        public Matrix(double[,] firstMatrix, double[,] secondMatrix)
        {
            _firstMatrix = firstMatrix;
            _secondMatrix = secondMatrix;
        }

        public double[,] Multiply(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
                throw new Exception("The number of columns of the first matrix doesn't equal to the number of rows of the second matrix ");

            double[,] result = new double[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

            for (int k = 0; k < firstMatrix.GetLength(0); k++)
            {
                for (int i = 0; i < secondMatrix.GetLength(1); i++)
                {
                    double sum = 0;

                    for (int j = 0; j < secondMatrix.GetLength(0); j++)
                    {
                        sum += firstMatrix[k, j] * secondMatrix[j, i];
                    }

                    result[k, i] = sum;
                }
            }

            return result;
        }

        public double Determinant(double[,] matrix)
        {
            if ((matrix.GetLength(0) < 2) || (matrix.GetLength(1) < 2))
            {
                return (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]);
            }

            double result = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                double[,] tmpMatrix = GetSmallerMatrix(matrix, 0, i);
                result += Math.Pow(-1, 0 + i)*matrix[0, i]*Determinant(tmpMatrix);
            }

            return result;
        }

        public double[,] InverseMatrix(double[,] matrix)
        {
            throw new NotImplementedException();
        }

        public double[,] Transpose(double[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1))
                throw new Exception("The number of rows doesn't equal to number of columns ");

            double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i >= j)
                    {
                        result[j, i] = matrix[i, j];
                        result[i, j] = matrix[j, i];
                    }
                }
            }


            return result;
        }


        private double[,] GetSmallerMatrix(double[,] matrix, int row, int column)
        {
            double[,] result = new double[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

            if (result.GetLength(0) < 2 || result.GetLength(1) < 2)
                throw new Exception("The length of the matrix can not be less than 2  ");

            for (int i = 0, currentRow = 0; i < matrix.GetLength(0); i++)
            {
                if (i == row) continue;

                for (int j = 0, currentColumn = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == column) continue;

                    result[currentRow, currentColumn] = matrix[i, j];

                    currentColumn++;
                }

                currentRow++;
            }

            return result;
        }
    }
}
