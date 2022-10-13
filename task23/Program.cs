// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]
Console.Clear();
Console.Write("Введите ряд чисел через запятую :  ");
int[] Arr()
{
    string[] count = Console.ReadLine()!.Split(",");
    int[] array;
    array = new int[count.Length];
    for (int i = 0; i < count.Length; i++)
    {
        array[i] = System.Int32.Parse(count[i]);
    }
    return array;
}

void PrintArray (int[] mass)
{   
    Console.Write("[");
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
        if (i != mass.Length - 1)
        {
            Console.Write(", ");

        }
    }
    Console.Write("]");
}
PrintArray(Arr());