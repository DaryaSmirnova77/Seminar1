// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] Array()
{
    int size = 4;
    int[,] matrix = new int[size, size];
    int k = 0;
    int j = 0;

    for (int count = 1; count <= size * size; count++)
    {
        matrix[k, j] = count;
        if (k <= j + 1 && k + j < size - 1) j++;
        else if (k < j && k + j >= size - 1) k++;
        else if (k >= j && k + j > size - 1) j--;
        else k--;
    }
    return matrix;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j]/ 10 <= 0) Console.Write($"0{inArray[i, j]}\t ");
            else Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
PrintArray(Array());