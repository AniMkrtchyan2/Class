using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMatrix
{
    class Matrix
    {
        
        public double[,] MultiplyMatrix(double[,] matrix1, double[,] matrix2)
        {

            double temp = 0;
            double[,] res = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

            if (matrix1.GetLength(1) != matrix2.GetLength(0))
                throw new Exception("exception");
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    temp = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        temp += matrix1[i, k] * matrix2[k, j];
                    }
                    res[i, j] = temp;
                }
            }
            return res;

        }
        public double[,] AdditionMatrix(double[,] matrix1, double[,] matrix2)
        {
            double[,] tmpmatrix = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
                throw new Exception("exception");
            for (int i = 0; i < tmpmatrix.GetLength(0); i++)
            {
                for (int j = 0; j < tmpmatrix.GetLength(1); j++)
                {
                    
                        tmpmatrix[i,j]= matrix1[i, j] + matrix2[i, j];            
                }
            }
            return tmpmatrix;
        }
        public double[,] ScalarMult(double[,] matrix1, double k)
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {

                    matrix1[i, j] = matrix1[i, j]*k;
                }
            }
            return matrix1;
        }

        public double[,] Transpose(double[,] matrix1)
       {  
            
         double[,] result = new double[matrix1.GetLength(1), matrix1.GetLength(0)];

          for (int i = 0; i < result.GetLength(0); i++)
           {    
             for (int j = 0; j < result.GetLength(1); j++)
              {
                 result[j, i] = matrix1[i, j];
               }
            }
 
              return result;
           }


    }
}
