// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix)
{
    int[,] resultMatrix = new int[firstMartrix.GetLength(0), secondMartrix.GetLength(1)];
    if (firstMartrix.GetLength(0) != secondMartrix.GetLength(1))
    {
        Console.WriteLine("Матрицы нельзя перемножить");
        return new int[0, 0];
    }
    for (int k = 0; k < resultMatrix.GetLength(0); k++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int i = 0; i < firstMartrix.GetLength(1); i++)
            {
                sum += firstMartrix[k, i] * secondMartrix[i, j];
            }
            resultMatrix[k, j] = sum;
        }
    }
    Console.WriteLine($"Произведение первой и второй матриц:");
    return resultMatrix;
}

Console.Clear();
Console.Write("Введите количество строк в первом массиве: ");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в первом массиве: ");
int columns1 = int.Parse(Console.ReadLine()!);
int[,] firstMartrix = GetArray(rows1, columns1, 1, 9);
Console.Write("Введите количество строк во втором массиве: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов во втором массиве: ");
int columns2 = int.Parse(Console.ReadLine()!);
int[,] secondMartrix = GetArray(rows2, columns2, 1, 9);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMartrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondMartrix);
Console.WriteLine();
PrintArray(MultiplyMatrix(firstMartrix, secondMartrix));
Console.WriteLine();
