// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void Main()
{
    Console.Clear();
    int R = ReadInt("Введите количество строк: ");
    int C = ReadInt("Введите количество столбцов: ");

    int[,] matr1 = FillMatrix(R, C, 1, 9);
    PrintMatrix(matr1);
    Console.WriteLine();

    int[,] matr2 = FillMatrix(C, R, 1, 9); 
    PrintMatrix(matr2);
    Console.WriteLine("Произведение двух матриц: ");

    PrintMatrix(MultiplicationMat(matr1, matr2));
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

int[,] MultiplicationMat(int[,] A, int[,] B)
{
    int[,] Matrix = new int[A.GetLength(0), B.GetLength(1)];
    for (int i = 0; i < A.GetLength(0); i++)
    {
        for (int j = 0; j < B.GetLength(1); j++)
        {
            for (int k = 0; k < B.GetLength(1) - 1; k++)
            {
                Matrix[i, j] += A[i,k] * B[k,j];
            }
            
        }
    }
    return Matrix;
}

Main();