//  Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


int GetMulti(int n)
{
    int multi = 1;
    for (int i = 1; i <= n; i++)
    {
        multi = multi * i;
    }
    return multi;
}
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int result = GetMulti(N);
Console.WriteLine(result);

