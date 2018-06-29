using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations.Matrix
{
    interface ICalculation
    {
        double[,] Multiply(double[,] firstMatrix, double[,] secondMatrix);
        double CalculateDeterminant(double[,] matrix);
        double[,] GetInverseMatrix(double[,] matrix);
        double[,] Transpose(double[,] matrix);

    }
}
