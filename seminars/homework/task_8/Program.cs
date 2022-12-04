/* Задача 8: Напишите программу, которая на вход принимает число (N),
             а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Enter your positive integer number"); // Запрос числа
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 1)                                     // Проверка числа на четность
{                                                        // Если number нечетное - уменьшим на 1
    number = number - 1;
}
Console.WriteLine("List of even numbers from 1 to number you have entered:");

for (int i = 2; i <= number; i=i+2)                      // Вывод на печать четных чисел от 2 до number
{
    Console.WriteLine(i);
}