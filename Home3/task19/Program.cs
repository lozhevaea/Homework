// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.WriteLine("Введите пятизначное число: ");
string? N = Console.ReadLine();
int n = Convert.ToInt32(Convert.ToString(N));

if (n < 10000 || n > 99999)
{
    System.Console.WriteLine("Число не пятизначное!");
}
else if (N![0] == N[4] && N[1] == N[3])
{
    System.Console.WriteLine("Число является палиндромом");
}
else
{
    System.Console.WriteLine("Число не является палиндромом");
}