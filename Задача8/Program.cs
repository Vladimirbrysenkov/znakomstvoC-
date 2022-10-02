// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine()!);
for (int N = 1; N <= x; N++)
if (N % 2 == 0)
{
    Console.WriteLine($"{N}");
}
