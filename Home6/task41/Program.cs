// Пользователь ввлдит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3


void Main()
{
    System.Console.Write("Введите числа через пробел: ");
    int[] Arr = Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse);
    PrintArray(Arr);
    System.Console.WriteLine($"Количество положительных чисел: {CountElem(Arr)}"); 
}

void PrintArray(int[]Arr)
{
    System.Console.WriteLine("[" + string.Join(", ", Arr) + "]");
}

int CountElem(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Main();

