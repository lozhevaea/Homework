// Напишите программу, которая найдет точку пересечения двух прямых 
// заданных уравнениями y = k1*x + b1, y = k2*x + b2; значения b1, k1, b2, k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Main()
{
    int[] arr = {ReadInt("Введите коэффициент первого уравнения: "), 
                 ReadInt("Введите свободный член первого уравнения: "), 
                 ReadInt("Введите коэффициент второго уравнения: "), 
                 ReadInt("Введите свободный член второго уравнения: ")};
    System.Console.WriteLine($"Ваша первая прямая: y = {arr[0]}*x + {arr[1]}");
    System.Console.WriteLine($"Ваша вторая прямая: y = {arr[2]}*x + {arr[3]}");
    IntersectionPoint(arr, out double X, out double Y);
    System.Console.WriteLine($"Точка пересечения ({X}, {Y})");
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void IntersectionPoint(int[] arr, out double X, out double Y)
{
    if (arr[3] < arr[1] || arr[0] < arr[2])
    {
        X = (double)(arr[3] - arr[1]) / (arr[0] - arr[2]);
    }
    else
    {
        X = (double)(arr[3] - arr[1]) / (arr[0] - arr[2]);
    }
    Y = arr[0] * X + arr[1];
}

 Main();
  