// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому.
// Если чилсло 2 не кратно числу 1, то программа выводит остаток от деления.
// 34,5 -> не кратно, остаток 4
// 16,4 -> кратно


Console.Clear();

Console.WriteLine("Введите первое число:");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int y = int.Parse(Console.ReadLine()!);
int result = x % y; 
if (result == 0)
{
    Console.WriteLine($"Число {x} кратно {y}");
}
else
{
    Console.WriteLine($"Число {x} не кратно {y}, остаток -> {result}");
}