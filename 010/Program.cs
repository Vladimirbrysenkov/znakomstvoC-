// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.


Console.Clear();
Console.WriteLine("Введите первое число:");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int ber = int.Parse(Console.ReadLine()!);

if (num * num == ber || ber * ber == num)
{
    System.Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}