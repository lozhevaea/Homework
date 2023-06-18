// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

void Main()
{
    Console.Clear();
    int M = ReadInt("Введите значение M: ");
    int N = ReadInt("Введите значение N: ");
    System.Console.WriteLine(Akkerm(M, N));

}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerm(int m, int n)
{
    if (m == 0) 
        return n + 1;
    if (m > 0 && n == 0) 
        return Akkerm(m - 1, 1);
    if (m > 0 && n > 0) 
        return Akkerm(m - 1, Akkerm(m, n - 1));
    return 0;
}

Main();