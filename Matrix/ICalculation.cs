using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations.Matrix
{
    /// <summary>
    /// It implements calculation process for different kind of matrix
    /// </summary>
    interface ICalculation
    {
        /// <summary>
        /// Multiplyes two matrixs
        /// </summary>
        /// <param name="firstMatrix">The first multiplyer</param>
        /// <param name="secondMatrix">The second multiplyer</param>
        /// <returns>The calculated matrix</returns>
        double[,] Multiply(double[,] firstMatrix, double[,] secondMatrix);

        double CalculateDeterminant(double[,] matrix);

        double[,] GetInverseMatrix(double[,] matrix);

        double[,] Transpose(double[,] matrix);

    }
}
