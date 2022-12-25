int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int digit)
{
    if (digit == 0) return 0;
    return (digit % 10 + SumNumbers(digit / 10));
}

Console.WriteLine(SumNumbers(number));