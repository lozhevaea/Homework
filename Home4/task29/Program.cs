//  Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] Array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        Array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return Array;
}


int[] Arr = FillArray(ReadInt("Введите размер массива: "), 
                      ReadInt("Введите левую границу массива: "), 
                      ReadInt("Введите правую границу массива: "));
System.Console.WriteLine("[" + string.Join(", ", Arr) + "]");