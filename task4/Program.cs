// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4; 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int x = 1;
bool not = true;
Console.WriteLine($"Чётные числа от 1 до {number}");
while (x <= number)
{
    if (x % 2 != 1)
    {Console.Write(x + ", ");
    not = false;
    }
    x++;
}
if (not)
{
   Console.WriteLine("Четных чисел нет"); 
}
