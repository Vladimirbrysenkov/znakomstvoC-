// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] GetArray(int m, int n)
{
    int[,] inArray = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            inArray[i, j] = new Random().Next(0, 21);
        }
    return inArray;
}
void PrintArray(int[,] inArray)
{

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void Main(int[,] inArray)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        int srAr = 0;
        int ColChetn = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            srAr += inArray[i, j];
            ColChetn += (inArray[i, j] % 2 == 0) ? 1 : 0;
        }
        Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {(float)srAr / row}");
        Console.WriteLine($"Количество четных элементов столбца {j + 1} = {ColChetn}");
    }
}

int[,] array = GetArray(row, columns);
PrintArray(array);
Console.WriteLine();
Main(array);
