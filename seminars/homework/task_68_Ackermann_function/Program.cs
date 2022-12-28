// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Упрощенная запись функции Аккермана (вариант Аккермена-Петера):
// A (0,n) = n + 1
// A (m+1, 0) = A(m,1)
// A (m+1, n+1) = A(m, A(m+1,n))


double A(double m, double n)
{
    if (m == 0) return n+1;
    else if (n == 0) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}

Console.Write("Введите значение m --> ");
double m = Convert.ToInt64(Console.ReadLine());
Console.Write("Введите значение n --> ");
double n = Convert.ToInt64(Console.ReadLine());
Console.Write($"Значение функции Аккермана А({m},{n}) = ");
Console.WriteLine(A(m, n));