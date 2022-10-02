// Напишите программу, которая на входе принимает число N,  
// а  на выходе  показывает все целые числа в промежутке от -N до N

Console.Clear();
Console.WriteLine("Введите число: ");
int X = int.Parse(Console.ReadLine()!);
int N2 = -X;
while(N2 <= X)
{
    Console.Write($"{N2} ");
    N2 = N2 +1;
}