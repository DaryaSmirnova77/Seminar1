// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵); 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine()!);

int Pow(int a, int b)
{
    int Pow = 1;
    for (int i = 1; i <= b; i++)
    {
        Pow = Pow * a;
    }
    return Pow;
}
      Console.WriteLine(Pow(A,B));
