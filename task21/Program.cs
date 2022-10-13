// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12


Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int count = NumCount(num);
SumNum(num, count);


int NumCount(int a)
{
    int i = 0;
    while (a > 0)
    {
        a /= 10;
        i++;
    }
    return i;
}

void SumNum(int n, int count)
{
    int sum = 0;
    for (int i = 1; i <= count; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}

