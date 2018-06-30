using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations.Matrix
{
    /// <summary>
    /// It implements calculation process for different kind of matrices
    /// </summary>
    interface ICalculation
    {
        /// <summary>
        /// Multiplyes two matrices
        /// </summary>
        /// <param name="firstMatrix">The first multiplyer</param>
        /// <param name="secondMatrix">The second multiplyer</param>
        /// <returns>The calculated matrix</returns>
        double[,] Multiply(double[,] firstMatrix, double[,] secondMatrix);

        /// <summary>
        /// Calculates a determinant
        /// </summary>
        /// <param name="matrix"> matrix to operate</param>
        /// <returns>calculated determinant</returns>
        double Determinant(double[,] matrix);

        /// <summary>
        /// Calculates an inverse matrix
        /// </summary>
        /// <param name="matrix">matrix to operate</param>
        /// <returns>inversed matrix</returns>
        double[,] InverseMatrix(double[,] matrix);

        /// <summary>
        /// Transposes a matrix
        /// </summary>
        /// <param name="matrix">matrix to transpose</param>
        /// <returns>the transposed matrix</returns>
        double[,] Transpose(double[,] matrix);

        /// <summary>
        /// Shows the content of the matrix
        /// </summary>
        /// <param name="matrix">matrix to operate</param>
        void ShowMatrix(double[,] matrix);

    }
}
