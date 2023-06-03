//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Main()
{
    int size = ReadInt("Введите размер массива: ");
    int[] Array = FillArray(size, 100, 999);
    PrintArray(Array);
    System.Console.WriteLine($"Количество четных чисел в массиве: {CountElem(Array)}");
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] Arr = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        Arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return Arr;
}

void PrintArray(int[]Arr)
{
    System.Console.WriteLine("[" + string.Join(", ", Arr) + "]");
}

int CountElem(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
Main();