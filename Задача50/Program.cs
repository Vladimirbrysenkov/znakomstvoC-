// Напишите программу, которая на вход принимает число и возвращает индексы элемента в двумерном массиве
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] GetRandomArray()
{
    int m = new Random().Next(1, 11);
    int n = new Random().Next(1, 11);
    int[,] inArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            inArray[i, j] = new Random().Next(0, 11);
        }
    }
    return inArray;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t  ");
        }
        Console.WriteLine();
    }
}
void FindNumInArray(int[,] matr, int number)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; i < matr.GetLength(1); j++)
        {
            if (matr[i, j] == number)
            {
                Console.WriteLine($"{number} - такое число есть в массиве!");
                Console.WriteLine($"Смотри столбец номер {j + 1} и строку номер {i + 1} ");
                return;
            }
        }
    }
    Console.WriteLine($"{number} - такого числа нет в массиве");
}
Console.Clear();
Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine()!);
int[,] myArray = GetRandomArray();
PrintArray(myArray);
Console.WriteLine();
FindNumInArray(myArray, number);
