﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
int count = num.ToString().Length;
if (count <= 2)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра введённого числа: {num.ToString()[2]}");
}

