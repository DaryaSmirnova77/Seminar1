// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Даны прямые заданные формулами y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите по очереди b1, k1, b2 и k2 через запятую c пробелом: ");
string[] number = Console.ReadLine()!.Split(", ");
double[] array = NewArray(number);

double x1 = X1(array);
double y1 = Y1(array, x1);

double[] NewArray(string[] inArray)
{
    double[] array = new double[inArray.Length];

    for (int i = 0; i < inArray.Length; i++)
    {
        array[i] = double.Parse(inArray[i]);
    }
    return array;
}

double X1 (double[] k)
{
    double x = (k[2] - k[0]) / (k[1] - k[3]);
    return x;
}

double Y1 (double[] b, double x)
{
    double y = b[1] * x + b[0];
    return y;
}

bool Result(double[] k)
{
    return k[1] == k[3] || k[0] == k[2] && k[1] == k[3];
}

if (Result(array))
{
    Console.Write("Прямые с такими параметрами паралельны");
}
else
{
    Console.WriteLine($"Координаты точки пересечения двух прямых: ({x1}; {y1})");
}


