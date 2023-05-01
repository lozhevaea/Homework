// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да 
// 7 -> да 
// 1 -> нет

System.Console.WriteLine("Введите день недели в виде числа: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 7)
{
    System.Console.WriteLine("Такого дня недели нет!");
}
else
{
    if (n == 6 || n == 7)
    {
        System.Console.WriteLine("Это выходной день");
    }
    else
    {
        System.Console.WriteLine("Это рабочий день");
    }
}