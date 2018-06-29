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
            }


            Console.WriteLine("It is the first message");
            Console.Read();
        }
    }
}
