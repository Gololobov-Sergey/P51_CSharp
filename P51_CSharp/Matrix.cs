using System;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{
    public class Matrix
    {
        private int[,] matrix;
        public int Rows { get; private set; }
        public int Cols { get; private set; }


        public Matrix(int row, int col)
        {
            matrix = new int[row, col];
            Rows = row;
            Cols = col;
        }

        public void Copy(int[,] mat)
        {
            Rows = mat.GetLength(0);
            Cols = mat.GetLength(1);
            matrix = new int[Rows, Cols];
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    matrix[i, j] = mat[i, j];
        }

        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void SetRandom(int minVal = 0, int maxVal = 9)
        {
            Random var = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = var.Next() % (maxVal - minVal + 1) + minVal;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.Rows == b.Rows && a.Cols == b.Cols)
            {
                Matrix mat = new Matrix(a.Rows, a.Cols);
                for (int i = 0; i < a.Rows; i++)
                {
                    for (int j = 0; j < a.Cols; j++)
                    {
                        mat[i, j] = a[i, j] + b[i, j];
                    }
                }

                return mat;
            }
            throw new NotImplementedException();
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.Cols == b.Rows)
            {
                Matrix mat = new Matrix(a.Rows, b.Cols);
                for (int i = 0; i < mat.Rows; i++)
                {
                    for (int j = 0; j < mat.Cols; j++)
                    {
                        mat[i, j] = 0;
                        for (int k = 0; k < a.Cols; k++)
                        {
                            mat[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }
                return mat;
            }
            else
                throw new NotImplementedException();
        }

        public int this[int row, int col]
        {
            get
            {
                if (row >= 0 && row < Rows && col >= 0 && col < Cols)
                    return matrix[row, col];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (row >= 0 && row < Rows && col >= 0 && col < Cols)
                {
                    matrix[row, col] = value;
                }
                else
                    throw new IndexOutOfRangeException();
            }
        }
    }
}
