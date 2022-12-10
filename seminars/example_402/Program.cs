
int CountDigit(int A)
{
    int count = 0;
    while (A > 0)
    {
        count += 1;
        A = A / 10;
    }
    return count;
}

Console.Write("Введите число A -> ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(CountDigit(N)); 

