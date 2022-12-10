// Напишите программу, которая принимает на вход число A
// и выдаёт сумму чисел от 1 до A

int GetSum(int A)
{
    int sum = 0;
    for (int i=1; i<=A; i++)
    {
        sum += i;
    }
    return sum;
}

Console.Write("Введите число A -> ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSum(N)); 