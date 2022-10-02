// Напишите программу, которая на входе принимает трехзначное число,  
// а  на выходе  показывает последнюю цифру этого числа

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{x%10}");
