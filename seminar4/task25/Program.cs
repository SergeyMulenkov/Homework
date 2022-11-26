//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int num1 = new Random().Next(1,5);
Console.WriteLine(num1);
int num2 = new Random().Next(1,5);
Console.WriteLine(num2);
Console.WriteLine($"Число {num1} в степени {num2}: " + exponentiation(num1, num2));

int exponentiation(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = num1 * result;
    }
    return result;
}