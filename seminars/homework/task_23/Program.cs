// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write ("Введите число N-> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Таблица кубов чисел от 1 до N:");

for (int i = 1; i <= n; i++)
{
    double square = Math.Pow((i),3);
    Console.WriteLine($"N = {i}: {square}");
}