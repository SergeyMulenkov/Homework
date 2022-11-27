// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

var array = FillArray(5);
Print(array);
Console.WriteLine();
int evenNumber = EvenNumber(array);
Console.WriteLine($"Количество четных чисел в массиве: {evenNumber}");

int EvenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;    
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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