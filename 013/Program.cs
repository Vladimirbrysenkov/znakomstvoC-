// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.


Console.Clear();
Console.Write("Введите X координаты точки A : ");
int ax = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты точки A : ");
int ay = int.Parse(Console.ReadLine()!);

Console.Write("Введите X координаты точки B : ");
int bx = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты точки B : ");
int by = int.Parse(Console.ReadLine()!);
double Dist(int x1, int y1, int x2, int y2)
{
    double result;
    //result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    //result = Math.Round(result,2);
    return result;
}
Console.Write($"Длина отрезка АВ равна: {Dist(ax, ay, bx, by):f2}");






