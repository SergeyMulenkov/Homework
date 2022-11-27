// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

var array = FillArray(10);
Print(array);
Console.WriteLine();
int sumElement = SumElement(array);
Console.WriteLine($"Сумма элементов на нечетных позициях: {sumElement}");

int SumElement(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        result += arr[i];
    }
    return result;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-100, 101);
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