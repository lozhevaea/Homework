//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//  и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Pow(int A, int B)
{
    int res = A;
    for (int i = 1; i < B; i++)
    {
        res = A * res;
    }
    return res;
}

System.Console.WriteLine(Pow(ReadInt("Введите число: "), ReadInt("Введите степень числа: ")));
