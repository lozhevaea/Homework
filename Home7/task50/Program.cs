// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значения этого элемента или же указание, что такого элемента нет.

// 1 7 -> такого числа в массиве нет

void Main()
{
    int[,] Matrix = FillMatrix(7, 7, 1, 99);
    PrintMatrix(Matrix);
    int I = ReadInt("Введите строку искомого элемента: ");
    int J = ReadInt("Введите солбец искомого элемента: ");
    System.Console.WriteLine(SearchElem(Matrix, I, J));
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

int SearchElem(int[,] matrix, int A, int B)
{
    int i = matrix.GetLength(0);
    int j = matrix.GetLength(1);
    int N = 0;
    if (A > i || B > j)
        {
            System.Console.WriteLine("Такого числа в массиве нет.");
        }
    else 
    {
        i = A - 1;
        j = B - 1;
        N = matrix[i,j];
    }    
            
    return N;
}

Main();