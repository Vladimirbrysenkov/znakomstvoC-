// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int temp = n;
int rev = 0;
while (n > 0)
{
    int dig = n % 10;
    rev = rev * 10 + dig;
    n = n /= 10;
}
if (temp == rev)
{
    Console.Write("Это палиндром!");
}
else
{
    Console.Write("Это не палиндром!");
}