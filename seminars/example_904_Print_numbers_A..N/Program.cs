int a = Convert.ToInt32(Console.ReadLine()); // a (правая граница)
int n = Convert.ToInt32(Console.ReadLine()); // N (правая граница)
// A; N: start = A, end = N
string PrintNumbers(int start, int end)
{
    // Базовый случай - выход из рекурсии
    if (start == end) return start.ToString(); // n = 2: res = 1, 2(start == end)
    // Рекурсивный случай

    return (start + ", " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(1, n));
