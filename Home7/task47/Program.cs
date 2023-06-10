﻿// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.

// 0,5  7  -2  -0,2
// 1  -3,3  8  -9,9
// 8   7,8 -7,1  9

void Main()
{
    double[,] Matrix = FillMatrix(ReadInt("Введите количество строк: "),ReadInt("Введите количество столбцов: "), -9, 9);
    PrintMatrix(Matrix);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    double[,] matrix = new double[row, col];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1) + Math.Round(rand.NextDouble(), 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t"); 
        }
        System.Console.WriteLine();
    }
}

Main();