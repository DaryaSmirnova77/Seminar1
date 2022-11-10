// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortRowsArray(int[,] inArray)
{
    for (int m = 0; m < inArray.GetLength(0); m++)
    {
        for (int n = 0; n < inArray.GetLength(1); n++)
        {
            for (int k = n + 1; k < inArray.GetLength(1); k++)
            {
                if (inArray[m, n] < inArray[m, k])
                {
                    int temp = inArray[m, n];
                    inArray[m, n] = inArray[m, k];
                    inArray[m, k] = temp;
                }
            }
        }
    }
    return inArray;
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int ns = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] array = GetArray(m, ns, 0, 10);
PrintArray(array);
Console.WriteLine();
int[,] result = SortRowsArray(array);
PrintArray(result);
