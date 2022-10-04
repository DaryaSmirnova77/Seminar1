//Написать программу, которая будет принимать на вход два числа и выводить, является ли второе число кратно первому

Console.Clear();

int num = new Random().Next(10,100);
int ber = new Random().Next(1,10);
int result = num % ber;
if(result == 0)
{
    Console.WriteLine($"Число {num} кратно {ber}");
}
else
{
    Console.WriteLine($"Число {num} не кратно {ber}, остаток - {result}");
}