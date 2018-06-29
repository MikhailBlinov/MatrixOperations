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
            /*
            double[,] firstMatrix = new double[,] { {1,1,1,1}, {2,2,2,2}, {3,3,3,3} };
            double[,] secondMatrix = new double[,] { {4,5,1},{ 4, 5, 1 },{ 4, 5, 1 },{ 4, 5, 1 } };


            Matrix matrix = new Matrix();

            double[,] result = matrix.Multiply(firstMatrix, secondMatrix);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write("{0} ", result[i,j]);
                }

                Console.WriteLine(Environment.NewLine);
            } */
            /*
            double[,] firstMatrix = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }};

            Matrix matrix = new Matrix(firstMatrix);

            double[,] result = matrix.Transpose(firstMatrix);

            ShowMatrix(firstMatrix);
            ShowMatrix(result);*/


            double[,] firstMatrix = new double[,] { { 1, 2, 0 }, { 3, 2, 1 }, { 0, 1, 2 } };

            Matrix matrix = new Matrix();

            double result = matrix.Determinant(firstMatrix);

            Console.WriteLine(" deteminant = {0}", result);

            Console.WriteLine("It is the first message");
            Console.Read();
        }

        private static void ShowMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }

                Console.WriteLine(Environment.NewLine);
            }

            Console.WriteLine(Environment.NewLine);
        }

    }
}
