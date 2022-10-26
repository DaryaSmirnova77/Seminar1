// Задача 50. Напишите программу, которая на вход принимает число, показывая что данный элемент есть, либо что такого элемента нет. выводит его, по
// Например, задан массив: 1 4 7 2;  5 9 2 3;  8 4 2 4; 17 -> такого числа в массиве нет

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


void FindNum(int[,] index, int number)
{
    for (int i = 0; i < index.GetLength(0); i++)
    {
        for (int j = 0; j < index.GetLength(1); j++)
        {
            if (index[i, j] == number)
            {
                Console.WriteLine($"{number} - такое число есть в массиве");
                return;
            } 
        }
    }
    Console.WriteLine($"{number} - такого числа в массиве нет");
}

Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите искомое число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] array = GetArray(row, columns, 0, 99);
PrintArray(array);
Console.WriteLine();
FindNum(array, number);