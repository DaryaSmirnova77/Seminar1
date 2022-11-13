// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// n = 3, n = 2 -> A(m,n) = 29

int FunctionAkkernumMan(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0) return FunctionAkkernumMan(numM - 1, 1);
    if (numM > 0 && numN > 0) return FunctionAkkernumMan(numM - 1, FunctionAkkernumMan(numM, numN - 1));
    return FunctionAkkernumMan(numM, numN);
}

Console.Clear();
Console.Write("Задайте значение m: ");
int numM = int.Parse(Console.ReadLine()!);
Console.Write("Задайте значение n: ");
int numN = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine($"Функция Аккермана для чисел A({numM},{numN}) = {FunctionAkkernumMan(numM, numN)}");