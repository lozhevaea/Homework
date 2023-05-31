//  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Решение через массив. Не понимаю, почему в основном коде не запускается цикл.
// int SumArr(int[] Arr)
// {
//     int sum = 0;
//     for (int i = 0; i < Arr.Length; i++)
//     {
//         sum = sum + Arr[i];
//     }
//     return sum;
// }

// System.Console.WriteLine("Введите число: ");
// int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
// int res = SumArr(A);
// System.Console.WriteLine("Сумма цифр в числе составляет: " + res);


// Решение через функции

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumN(int N)
{
    int sum = 0;
    while (N > 0)
    {
        sum = sum + N % 10;
        N = N / 10;
    }
    return sum;
}

int A = ReadInt("Введите число: ");
System.Console.WriteLine("Сумма цифр в числе составляет: " + SumN(A));
