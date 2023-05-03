// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679345 -> 6

// System.Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a = n.ToString().Length;

// int result = 0;
// int b = 1;

// Решение задачи с помощью ветвления и цикла while

// if (a < 3)
// {
//     Console.Write("Третьей цифры нет. ");
// }
// else
// {
// int i = a;
// while (i > 3)
// {
//      b = b * 10;
//      i = i - 1;
// }
// result = n / b % 10;
// System.Console.WriteLine(result);
// }


//Решение задачи с помощью цикла for и с преобразованием вещественных чисел в целые.
//Если четвертая цифра >5, то идет округление. Не знаю как этого избежать!

System.Console.WriteLine("Введите число: ");
double n = Convert.ToDouble(Console.ReadLine());
int a = n.ToString().Length;
int result = 0;
int b = 1;

if (a < 3)
{
    Console.Write("Третьей цифры нет. ");
}
else 
{
for (int i = 0; i < a; i++)
{
    b = b * 10;
}
result = Convert.ToInt32(Convert.ToDouble(n / b * 1000))% 10;
System.Console.WriteLine(result);
}


// Решение задачи через строковую переменную

// System.Console.WriteLine("Введите число: ");
// string? str = Console.ReadLine();
// int  num = Convert.ToInt32(Convert.ToString(str![2]));
// System.Console.WriteLine(num);