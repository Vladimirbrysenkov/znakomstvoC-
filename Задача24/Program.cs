// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetSum(int A)
{
    int sum = 0;
    for (int i = 0; i <= A; i++)
    {
        sum += i;  // sum = sum+1;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите A: ");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(GetSum(n));