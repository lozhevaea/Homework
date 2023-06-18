// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//  натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Main()
{
    Console.Clear();
    int M = ReadInt("Введите значение M: ");
    int N = ReadInt("Введите значение N: ");
    if (M < N)
    {
        System.Console.WriteLine(SumNumbers(M, N));
    }
    else
    {
        System.Console.WriteLine(SumNumbers(N, M));
    }

}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int m, int n)
{
    int sum = m;
    if (m > n) return 0;
    return sum += SumNumbers(m + 1, n);

}

Main();