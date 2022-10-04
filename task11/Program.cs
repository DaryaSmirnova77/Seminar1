// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6

Console.Clear();
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
if (Math.Abs(num) < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    if (Math.Abs(num) >1000)
    while (Math.Abs(num) >1000)
    {
        num = num/10;
    }
    Console.WriteLine($"Третья цифра введённого числа: {Math.Abs(num) % 10}");
}
