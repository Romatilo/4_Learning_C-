// Напишите программу, которая принимает на вход число N и выдаёт 
// произведение чисел от 1 до N.
// 4 -> 24 5 -> 120



int GetMultiply(int A)
{
    int mult = 1;
    for (int i=1; i<=A; i++)
    {
        mult = mult*i;
    }
    return mult;
}

Console.Write("Введите число A -> ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetMultiply(N)); 