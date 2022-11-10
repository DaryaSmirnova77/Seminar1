// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue+1);
        }
    
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void IndexMinSumn (int[,] array)
{
    int tempSumLine;
    int minSumLine = 0;
    int result = 0;
    for (int m = 0; m < array.GetLength(1); m++)
    {
        minSumLine += array[0, m];
    }
    for (int n = 0; n < array.GetLength(0); n++)
    {
        tempSumLine = 0;
        for (int m = 0; m < array.GetLength(1); m++)
        {
            tempSumLine += array[n, m];
        }
        if (tempSumLine < minSumLine)
        {
            minSumLine = tempSumLine;
            result = n;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result + 1}");
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);

Console.WriteLine();
IndexMinSumn(array);