// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12


int GetSumDigits(int number)        // Метод подсчета всех цифр числа
{
    int sumDigits = 0;
    while (number > 0)
    {
        sumDigits += number % 10;   // Добавляем последнюю цифру числа в сумму
        number /= 10;               // Отсекаем последнюю цифру числа
    }
    return sumDigits;
}

Console.Write("Введите число A -> ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSumDigits(A)); 