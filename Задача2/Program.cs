// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите первое число:");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int y = int.Parse(Console.ReadLine()!);
if (x > y )
{
    Console.WriteLine($"Число {x} больше чем {y}");
}
else if (x == y)
{
    Console.WriteLine($"Число {x} равно {y}");
}
else if (x < y)
{
    Console.WriteLine($"Число {x} меньше {y}");
}