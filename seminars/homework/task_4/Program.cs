/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Enter 1st number");                    // Запрос трех чисел
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2st number");
int numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 3rd number");
int numberThree = Convert.ToInt32(Console.ReadLine());

int max = numberOne;                    // Минимальное и максимальное значения приме 
int min = numberOne;

if (numberTwo > max)                    // Сравниваем второе число с максимальным (первым)
{
    max = numberTwo;
}
else
{
    min = numberTwo;
}

if (numberThree > max)                  // Сравниваем третье число с максимальным
{
    max = numberThree;
}
else
{
    if (numberThree < min)              // Сравниваем третье число с минимальным
    {
        min = numberThree;
    }
}
Console.Write("Max number is ");        // Вывод результатов на экран
Console.WriteLine(max);
Console.Write("Min number is ");
Console.WriteLine(min);