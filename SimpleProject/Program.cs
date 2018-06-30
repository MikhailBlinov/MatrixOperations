using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixOperations.Matrix;

namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region     The Matrix multiplication test
            /*

                          double[,] firstMatrix = new double[,] { {1,1,1,1}, {2,2,2,2}, {3,3,3,3} };
                          double[,] secondMatrix = new double[,] { {4,5,1},{ 4, 5, 1 },{ 4, 5, 1 },{ 4, 5, 1 } };


                          Matrix matrixObject = new Matrix();

                          double[,] result = matrixObject.Multiply(firstMatrix, secondMatrix);

                          for (int i = 0; i < result.GetLength(0); i++)
                          {
                              for (int j = 0; j < result.GetLength(1); j++)
                              {
                                  Console.Write("{0} ", result[i,j]);
                              }

                              Console.WriteLine(Environment.NewLine);
                          }

                          matrixObject.ShowMatrix(result);
                          //16 20 4
                          //32 40 8
                          //48 60 12
  */

            #endregion

            #region  The TRANSPOSE MATRIX Test 
            /*
             double[,] firstMatrix = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }};

             Matrix matrixObject = new Matrix(firstMatrix);

             double[,] result = matrixObject.Transpose(firstMatrix);

             matrixObject.ShowMatrix(firstMatrix);
             matrixObject.ShowMatrix(result);
             //1 4 7
             //2 5 8
             //3 6 9
            */
            #endregion

            #region The DETERMINANT CALCULATION test
            /*
            double[,] firstMatrix = new double[,] { { 1, 2, 0 }, { 3, 2, 1 }, { 0, 1, 2 } };

            Matrix matrixObject = new Matrix();

            double result = matrixObject.Determinant(firstMatrix);

            Console.WriteLine(" deteminant = {0}", result);
            // -9
            */
            #endregion

            #region INVERSE MATRIX test
            
            double[,] firstMatrix = new double[,] { { 1, 2, 0 }, { 3, 2, 1 }, { 0, 1, 2 } };

            MatrixOperations.Matrix.MatrixOperations matrixObject = new MatrixOperations.Matrix.MatrixOperations();

            double[,] result = matrixObject.InverseMatrix(firstMatrix);

            matrixObject.ShowMatrix(result);
            //-0.33 1.33  0.00
            // 1.33 -0.44 0.11
            // 0.00 0.11  0.89

            //-0.33 1.33 0.00
            //1.33  -0.44 0.11
            //0.00  0.11  0.89
            #endregion

            Console.WriteLine("It is the first message");
            Console.Read();
        }
    }
}
