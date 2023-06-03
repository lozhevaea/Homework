//  Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
//  максимальным и минимальным элементов массива.

// [3.21 7.68 22.11 2 78] -> 76

void Main()
{
    string[] arr = {"Введите размер массива: ", 
                    "Введите левую границу массива: ", 
                    "Введите правую границу массива: "};
    double[] Array = FillArray(ReadInt(arr[0]), ReadInt(arr[1]), ReadInt(arr[2]));
    PrintArray(Array);
    System.Console.WriteLine($"Разность элементов: {Math.Round(DiffereceMaxMin(Array), 2)}");
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[] FillArray(int size, int leftRange, int rightRange)
{
    double[] Arr = new double[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        Arr[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 2);
    }
    return Arr;
}

void PrintArray(double[]Arr)
{
    System.Console.WriteLine("[" + string.Join(", ", Arr) + "]");
}

double DiffereceMaxMin(double[] Array)
{
    double max = Array[0];
    double min = Array[0];
    double res = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max)
        {
            max = Array[i];
        }
        if (Array[i] < min)
        {
            min = Array[i];
        }
    }
    res = max - min;
    return res;
} 

Main();
