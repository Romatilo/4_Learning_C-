// Задача 42: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Для начала выведем значения x и y из системы уравнений:
// |y = k1 * x + b1  | x(k1 - k2) + (b1 - b2) = 0 | x = (b2 - b1) / (k1 - k2)
// |y = k2 * x + b2  | y = k2 * x + b2            | y =  k2(b1 - b2) / (k1 - k2) + b2

Console.WriteLine("Введите значения b1 -> ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значения k1 -> ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значения b2 -> ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значения k2 -> ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = Math.Round((b2 - b1) / (k1 - k2),2);
double y = Math.Round(((k2*(b2 - b1)) / (k1 - k2) + b2),2);
Console.WriteLine($"Прямые пересекаются в следующих координатах: ({x}; {y})");