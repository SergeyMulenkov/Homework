// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

var array = FillArray(10);
Print(array);
Console.WriteLine();
int max = maxNum(array);
int min = minNum(array);
int DifferenceElement = max - min;
Console.WriteLine($"Разница между макс и мин: {DifferenceElement}");

int maxNum (int[] arr)
{
    int maxNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNum)
        {
            maxNum = arr[i];
        }
    }
    return maxNum;
}

int minNum (int[] arr)
{
    int minNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNum)
        {
            minNum = arr[i];
        }
    }
    return minNum;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void Print(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"{item}, ");
    }
}