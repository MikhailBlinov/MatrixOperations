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
         private double[,]  _resultMatrix = null;

         public double[,] ResultMatrix => _resultMatrix;

         public  Matrix()
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
            if(firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
                throw new Exception("The number of columns of the first matrix doesn't equal to the number of rows of the second matrix ");

            double[,] result = new double[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

            for (int k = 0; k < firstMatrix.GetLength(0); k++)
            {
                for (int i = 0; i < secondMatrix.GetLength(1); i++)
                {
                    double sum = 0;

                    for (int j = 0; j < secondMatrix.GetLength(0); j++)
                    {
                        sum += firstMatrix[k, j]*secondMatrix[j, i];
                    }

                    result[k, i] = sum;
                }
            }

            return result;
        }

        public double CalculateDeterminant(double[,] matrix)
        {
            throw new NotImplementedException();
        }

        public double[,] GetInverseMatrix(double[,] matrix)
        {
            throw new NotImplementedException();
        }

        public double[,] Transpose(double[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1))
                throw new Exception("The number of rows doesn't equal to number of columns ");

            double[,] result = new double[matrix.GetLength(0),matrix.GetLength(1)];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i >= j)
                    {
                        result[j,i] = matrix[i, j];
                        result[i, j] = matrix[j, i];
                    }
                }
            }


            return result;
        }
    }
}
