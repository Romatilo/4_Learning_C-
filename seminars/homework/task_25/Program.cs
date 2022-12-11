// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int GetExponent(int A, int B)               // Метод возведения числа А в степень B
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result *= A;
    }
    return result;
}

Console.Write("Введите A - число, возводимое в степень -> ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B - степень, в которую возводится число А-> ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write(GetExponent(M, N));

/*
int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
var str = string.Join(", ", GetArray());
Console.WriteLine("[" + str + "]");
*/