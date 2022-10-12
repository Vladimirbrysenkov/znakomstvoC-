// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Write("Введите количество элементов массива: ");
int elementCount = int.Parse(Console.ReadLine()!);
int[] numbers = new int[elementCount];
Console.Write("[");
if (elementCount <= 8)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 99);
        Console.Write(" " + Method(i) + " ");
        if (i != numbers.Length - 1)
        {
            Console.Write(", ");
        }
    }
}
Console.Write("]");
if (elementCount == 0)
{
    Console.Write("Ноль элементов массива!");
}
if (elementCount > 8)
Console.Write("Ошибка! Введите правильное количество элементов массива!");
int Method(int a)
{
    return numbers[a];
}
