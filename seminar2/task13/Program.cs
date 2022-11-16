// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число и нажмите ENTER: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
    while (number >= 1000)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine($"Третья цифра этого числа: {number}");
}
else
{
    Console.WriteLine("Третья цифра у этого числа: ОТСУТСВУЕТ!!!");
}