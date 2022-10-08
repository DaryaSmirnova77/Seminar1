// Напишите программу, котора на вход принимает координаты точки X,Y и выдает номер четверти плоскости, в которой находится координата
Console.Clear();
Console.WriteLine("Введите X: ");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите Y: ");
int y = int.Parse(Console.ReadLine()!);

if (x > 0)
{
    if (y > 0)
    {
        Console.WriteLine("Первая четверть");
    }
    else
    {
        Console.WriteLine("Четвертая четверть");
    }
}
else
{
    if (y > 0)
    {
        Console.WriteLine("Вторая четверть");
    }
    else
    {
        Console.WriteLine("Третья четверть");
    }
}