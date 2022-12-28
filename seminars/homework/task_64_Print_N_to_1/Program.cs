// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(Console.ReadLine()); // N (левая граница)
string PrintNumbers(int start)
{
    // Базовый случай - выход из рекурсии
    if (start == 1) return start.ToString();
    // Рекурсивный случай

    return (start + ", " + PrintNumbers(start - 1));
}

Console.WriteLine("Все числа от N до 1:");
Console.WriteLine(PrintNumbers(n));