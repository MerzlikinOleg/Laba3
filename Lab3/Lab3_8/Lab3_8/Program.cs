﻿using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите матрицу N*N: ");
        int N = int.Parse(Console.ReadLine());
        double[,] matrix = new double[N, N];
        if (N <= 0)
        {
            Console.WriteLine("Ошибка, N должно быть больше 0!");
        }
        else
        {
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("Определитель матрицы равен: " + DeterminantMatrix(matrix));
            Console.ReadKey();
        }

        static double[,] getMinor(double[,] matrix, int n)
        {
            double[,] result = new double[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0, column = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == n)
                        continue;
                    result[i - 1, column] = matrix[i, j];
                    column++;
                }
            }
            return result;
        }

        static double DeterminantMatrix(double[,] matrix)
        {
            if (matrix.Length == 1)
                return matrix[0, 0];
            if (matrix.Length == 4)
                return matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];
            else
            {
                double result = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    double[,] Minor = getMinor(matrix, i);
                    result += Math.Pow(-1, i) * matrix[0, i] * DeterminantMatrix(Minor);                       
                }
                return result;
            }
        }
    }
}