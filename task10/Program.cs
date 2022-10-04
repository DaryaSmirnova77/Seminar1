// Задача 13: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да; 7 -> да; 6 -> да
Console.Clear();
Console.WriteLine("Введите цифру от 1 до 7:");
int num = int.Parse(Console.ReadLine()!);
if (num >= 1 && num <= 7)
{
    if (num == 6 | num == 7) 
    Console.WriteLine("Выходной день");
    else 
    Console.WriteLine("Рабочий день");
}
else
{
    Console.WriteLine("Условие не выполнено, повторите попытку");
}
