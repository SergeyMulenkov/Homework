// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число и введите ENTER: ");
int number = Convert.ToInt32(Console.ReadLine());

int evennumber = 2;

if (number > 1);
{
    while (evennumber <= number)
    {
        Console.Write(evennumber + " ");
        evennumber = evennumber + 2;
    }
}