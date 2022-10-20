// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 4


int[] NewArray(string[] inArray)
{
    int[] array = new int[inArray.Length];

    for (int i = 0; i < inArray.Length; i++)
    {
        array[i] = int.Parse(inArray[i]);
    }
    return array;
}

int ResultArray (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
        count++;
        }
    }
    return count;

}

Console.Clear();
Console.Write("Введите числа через запятую c пробелом: ");
string[] numbers = Console.ReadLine()!.Split(", ");

int[] array = NewArray(numbers);
Console.WriteLine($"Количество чисел в массиве больше 0 -> {ResultArray(array)} ");