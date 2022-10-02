// Напишите программу, которая на входе принимает число N,  
// а  на выходе  показывает все целые числа в промежутке от -N до N

Console.Clear();
Console.WriteLine("Введите число: ");
int X = int.Parse(Console.ReadLine()!);
int N2 = X * -1;
int index = N2;
Console.Write(N2);
while(index < X)
{
    N2 = N2 +1;
    Console.Write(N2);
    index = index + 1;
}