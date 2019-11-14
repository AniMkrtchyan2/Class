using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 N, M, N1, M1;
            Random rnd = new Random();
            Console.Write(" count of rows matrix1 -");
            N = Int32.Parse(Console.ReadLine());
            Console.Write(" count of columns matrix1-");
            M = Int32.Parse(Console.ReadLine());
            double[,] matrix1 = new double[N, M];
            for (int i = 0; i < matrix1.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix1.GetLength(1); ++j)
                {
                    matrix1[i, j] = rnd.Next(10);
                    Console.Write(String.Format("{0}\t", matrix1[i, j]));
                }
                Console.Write(Environment.NewLine);

            }
            Console.Write(" count of rows matrix2-");
            N1 = Int32.Parse(Console.ReadLine());
            Console.Write(" count of columns matrix2-");
            M1 = Int32.Parse(Console.ReadLine());

            double[,] matrix2 = new double[N1, M1];


            for (int i = 0; i < matrix2.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix2[i, j] = rnd.Next(10);
                    Console.Write(String.Format("{0}\t", matrix2[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("Matrix Multiplication");
            Matrix temp = new Matrix();
            double[,] result = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
            result = temp.MultiplyMatrix(matrix1, matrix2);

            for (int i = 0; i < result.GetLength(0); ++i)
            {
                for (int j = 0; j < result.GetLength(1); ++j)
                {
                    Console.Write(String.Format("{0}\t", result[i, j]));
                }
                Console.Write(Environment.NewLine);

            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("Matrix Addition");
            Matrix tmpmatrix = new Matrix();
            double[,] Add = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
            Add = tmpmatrix.AdditionMatrix(matrix1, matrix2);
            for (int i = 0; i < Add.GetLength(0); ++i)
            {
                for (int j = 0; j < Add.GetLength(1); ++j)
                {
                    Console.Write(String.Format("{0}\t", Add[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("Scalar Product Matrix is");
            Matrix Scalarmatrix = new Matrix();
            double k = Double.Parse(Console.ReadLine());
            matrix1 = Scalarmatrix.ScalarMult(matrix1, k);
            for (int i = 0; i < matrix1.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix1.GetLength(1); ++j)
                {
                    Console.Write(String.Format("{0}\t", matrix1[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
          
            Console.Write(Environment.NewLine);
            Console.WriteLine("Matrix Trasponse");
            Matrix Transposematrix = new Matrix();
            double[,] Transpose= new double[matrix1.GetLength(1), matrix1.GetLength(0)];
            Transpose =Transposematrix.Transpose(matrix1);
            for (int i = 0; i < Transpose.GetLength(1); ++i)
            {
                for (int j = 0; j < Transpose.GetLength(0); ++j)
                {
                    Console.Write(String.Format("{0}\t", Transpose[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
            Console.ReadKey();


        }
    }
}
