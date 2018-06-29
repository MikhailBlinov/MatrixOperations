using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations.Matrix
{
     public class Matrix
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

    }
}
