// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();
Console.Write("Введите A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите B: ");
int b = int.Parse(Console.ReadLine()!);

// int st = a;
// for (int i = 1; i < b; i++)
//{
//st = st * a;
//
//}
int GetPow(int A, int B)
{
    int pow = 1;
    int i = 0;
    while (i < B)
    {
        pow = pow * A;
        i = i + 1;
    }
    return pow;
}
Console.Write ("А в степени B равно: ");
Console.WriteLine(GetPow(a, b));