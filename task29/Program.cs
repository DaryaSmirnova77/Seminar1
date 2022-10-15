// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int ResultArray (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
           count++; 
        }
    }
    return count;

}

Console.Clear();
int[] array = GetArray(6, 100, 1000);
int newArray = ResultArray (array);
Console.WriteLine($"В массиве: [{String.Join(", ", array)}]\n"+ $"Чётных чисел: {newArray}");


