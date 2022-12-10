﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine(SummaDigits(4, 8));
int SummaDigits(int num1, int num2)
{
    if (num1 == num2)
    {
        return num1;
    }
    if (num1 < num2)
    {
        return num2 + SummaDigits(num1, num2 - 1);
    }
    return num2 + SummaDigits(num1, num2 + 1);
}