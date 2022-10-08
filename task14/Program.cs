// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите X координаты точки A: ");
int ax = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты точки A: ");
int ay = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координаты точки A: ");
int az = int.Parse(Console.ReadLine()!);

Console.Write("Введите X координаты точки B: ");
int bx = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты точки B: ");
int by = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координаты точки B: ");
int bz = int.Parse(Console.ReadLine()!);

double Dist (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result;
    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z1 - z2, 2));
    return result;
}

Console.Write($"Длинна отрезка {Dist (ax, ay, az, bx, by, bz):F2}");

