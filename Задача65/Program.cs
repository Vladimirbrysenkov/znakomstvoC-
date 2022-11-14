// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


string GetPrint(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    Console.WriteLine($"{start}");
    return start + " " + GetPrint(start + 1, end);
}
Console.Clear();
Console.Write("Введите чило M ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите чило N ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetPrint(m, n));
