// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int[] array = GetArray(6, 1, 10);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i]; 
    }
    if (min > array[i])
    {
        min = array[i];
    }
}


Console.WriteLine($"[{String.Join(", ", array)}]\n" + $"Max = {max}\n" + $"Min = {min}\n" + $"Разница = {max - min}");