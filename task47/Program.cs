// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int GetPrint(int start, int end)
{
    if (start == end) return end;
    if (start > end) return start + GetPrint(start - 1, end);
    else return start + GetPrint(start + 1, end);
}

Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма натуральных элементов в промежутке между M и N -> {GetPrint(m, n)}");
