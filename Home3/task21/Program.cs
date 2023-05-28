// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// string[] array = {"Введите координату X точки A: ", 
//                   "Введите координату Y точки A: ", 
//                   "Введите координату Z точки A: ", 
//                   "Введите координату X точки B: ", 
//                   "Введите координату Y точки B: ", 
//                   "Введите координату Z точки B: "};

// int[] coordsA = new int [3];
// coordsA[0] = ReadInt(array[0]);
// coordsA[1] = ReadInt(array[1]);
// coordsA[2] = ReadInt(array[2]);

// int[] coordsB = new int [3];
// coordsB[0] = ReadInt(array[3]);
// coordsB[1] = ReadInt(array[4]);
// coordsB[2] = ReadInt(array[5]);

// double distance = Math.Sqrt(Math.Pow(coordsA[0] - coordsB[0], 2) 
//                           + Math.Pow(coordsA[1] - coordsB[1], 2) 
//                           + Math.Pow(coordsA[2] - coordsB[2], 2));
                          
// System.Console.WriteLine(Math.Round(distance, 2));



// Возможность вводить координаты одной строкой через 
// пробел и выводить их на экран.

System.Console.WriteLine("Введите координаты в соответветствующем порядке: X, Y, Z");
int[] coordsA = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
System.Console.WriteLine("Координаты: (Вывод при помощи string.Join)");
System.Console.WriteLine("[" + string.Join(", ", coordsA) + "]");

System.Console.WriteLine("Координаты: (Вывод при помощи цикла for)");
for (int i = 0; i < coordsA.Length; i++)
{
    System.Console.Write(coordsA[i] + " ");
}
