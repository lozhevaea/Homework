//  Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Main()
{
    string[] arr = {"Введите размер массива: ", 
                    "Введите левую границу массива: ", 
                    "Введите правую границу массива: "};
    int[] Array = FillArray(ReadInt(arr[0]), ReadInt(arr[1]), ReadInt(arr[2]));
    PrintArray(Array);
    System.Console.WriteLine($"Сумма элементов: {SumElem(Array)}");
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

int SumElem(int[] Arr)
{
    int sum = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += Arr[i];
        }        
    }
    return sum;
}

Main();

// Данная функция не работает, не понимаю почему.
// int SumElem(int[] Arr)
// {
//     int sum = 0;
//     for (int i = 1; i < Arr.Length; i+2)
//     {
//         sum += Arr[i];
//     }
//     return sum;
// }