int Factorial(int number)
{
    if (number == 1) return 1;
    return number * Factorial(number - 1);
}

Console.WriteLine(Factorial(6));