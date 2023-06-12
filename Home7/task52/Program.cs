﻿// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 

void Main()
{
    int[,] Matrix = FillMatrix(ReadInt("Введите количество строк: "), ReadInt("Введите количекство столбцов: "), 1, 9);
    PrintMatrix(Matrix);
    System.Console.WriteLine($"Среднее арифметическое каждого столбца: ");
    PrintArray(AverageElem(Matrix));
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

double[] AverageElem(int[,] matrix)
{
    double[] mat = new double[matrix.GetLength(1)];
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int res = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            res += matrix[i,j];
            mat[j] = Math.Round((double) res/matrix.GetLength(0), 1);
        }      
    }
    return mat;
}

void PrintArray(double[]Arr)
{
    System.Console.WriteLine("[" + string.Join(", ", Arr) + "]");
}

Main();