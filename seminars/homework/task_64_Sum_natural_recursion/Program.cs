// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M --> ");
int m = Convert.ToInt32(Console.ReadLine()); // M (левая граница)
Console.Write("Введите значение N --> ");
int n = Convert.ToInt32(Console.ReadLine()); // N (правая граница)
int sum = 0;
//  start = M, end = N
int SumNumbers(int start, int end)
{
    sum += start;
    // Базовый случай - выход из рекурсии:
    if (start >= end) return sum;

    // Рекурсивный случай:
    return (SumNumbers(start + 1, end));
}

Console.WriteLine("Сумма натуральных чисел от M до N: " + SumNumbers(m, n));