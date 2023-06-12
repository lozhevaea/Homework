// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Main()
{
    Console.Clear();
    int[,] Matrix = FillMatrix(ReadInt("Введите количество строк: "), ReadInt("Введите количество столбцов: "), 1, 9);
    PrintMatrix(Matrix);
    PrintArray(SumElem(Matrix));
    System.Console.WriteLine($"Строка с наименьшей суммой элементов: {MinElem(SumElem(Matrix))}");
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

int[] SumElem(int[,] mat)
{
    int[] Arr = new int[mat.GetLength(0)];
    for (int k = 0; k < mat.GetLength(0); k++)
    {
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                sum += mat[i,j];
            }
            Arr[i] = sum; 
        }
    }
    return Arr;
}

void PrintArray(int[]Arr)
{
    System.Console.WriteLine("[" + string.Join(", ", Arr) + "]");
}

int MinElem(int[] arr)
{
    int index = 1;
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            index = i + 1;
        }
    }
    return index;
}

Main();
