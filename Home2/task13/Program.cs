// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679345 -> 6

System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = n.ToString().Length;

int result = 0;

if (a < 3)
{
    Console.Write("Третьей цифры нет. ");
}
else
{
    int b = 1;
    int i = a;
    while (i < 3)
    {
        b = b * 10;
        i = i - 1;
    }
    result = n / b % 10;
    System.Console.WriteLine(result);
}

// for (int i = a; i <= 3; i--)
//     {
//         b = b * 10;
//     }
//     result = n / b % 10;