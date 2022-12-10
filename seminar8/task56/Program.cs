// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[4,4];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int[] summaElementsRow = SummaElementsRow(array);
(int, int) SmallestSummaRow = TheSmallestSummaRow(summaElementsRow);
Console.WriteLine($"Минимальная сумма, строка: {SmallestSummaRow}");

int[] SummaElementsRow(int[,] arr)
{
    int[] summaElements = new int[arr.GetLength(0)];
    int summa = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            summa += array[i, j];
            summaElements[i] = summa;
        }
        summa = 0;
    }
    return summaElements;
}

(int, int) TheSmallestSummaRow(int[] array)
{
    int resultSumma = array[0];
    int resultRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < resultSumma)
        {
            resultSumma = array[i];
            resultRow = i;
        }
    }
    return (resultSumma, resultRow);
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10, 100);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}