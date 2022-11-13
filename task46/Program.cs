// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string GetPrint(int num)
{
    if (num < 1) return $"Число не является натуральным";
    if (num == 1) return $"{1}";
    else return $"{num}, " + GetPrint(num - 1);
}

Console.Clear();
Console.Write("Введите значение N: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"N = {num} -> \"{GetPrint(num)}\"");

