// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите цифру, обозначающую день недели: ");
int n = int.Parse(Console.ReadLine()!);
void Checking(int n)
{
    if (n == 6 || n == 7)
    {
        Console.WriteLine("(Этот день выходной?) -> да");
    }
    else if (n < 1 || n > 7)
    {
        Console.WriteLine("Это не день недели!");
    }
    else Console.WriteLine("(Этот день выходной?) -> нет");
}
Checking(n);