// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу 
// квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число и нажмите ENTER: ");

var num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine(Math.Pow(i,2));
}

// Console.Write("Введите число ");
// var number = Convert.ToInt32(Console.ReadLine());
// int number2 = 1;

// while (number2 <= number)
// {
//     Console.WriteLine(number2*number2);
//     number2 ++;
// }
