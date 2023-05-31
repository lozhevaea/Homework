//  Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


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
        sum += N % 10;
        N = N / 10;
    }
    return sum;
}

int A = ReadInt("Введите число: ");
System.Console.WriteLine("Сумма цифр в числе составляет: " + SumN(A));
