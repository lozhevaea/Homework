// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Main()
{
    Console.Clear();
    int[,] Matrix = FillMatrix(ReadInt("Введите количество строк: "),ReadInt("Введите количество столбцов: "), 1, 9);
    PrintMatrix(Matrix);
    System.Console.WriteLine($"Матрица с упорядоченными по убыванию элементами: ");
    PrintMatrix(MaxMinElem(Matrix));   
    
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

int[,] MaxMinElem(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1) -1; j++)
        {
            for (int k = 0; k < mat.GetLength(1)-1 -j; k++)
            if (mat[i, k] < mat[i, k+1])
            {
                int temp = mat[i, k];
                mat[i, k] = mat[i, k+1];
                mat[i, k+1] = temp;
            }
            
        }
    }
    return mat;
}
Main();