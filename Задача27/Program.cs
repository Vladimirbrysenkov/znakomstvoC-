// Напишите функцию и запустите ее, которая
// принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine()!);
int Summ(int n)
{
    int res = 0;
    while (n > 0)
    {
        res = res + (n % 10);
        n = n / 10;
    }
    return res;
}
Console.WriteLine($"Cумма всех цифр числа {N} равна {Summ(N)}.");
