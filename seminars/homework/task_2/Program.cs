/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Enter 1st number");                      // Запрос чисел
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2st number");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberTwo >= (numberOne))                               // Сравнение чисел
{
    Console.Write("Max number is ");
    Console.WriteLine(numberTwo);
    Console.Write("Min number is ");
    Console.WriteLine(numberOne);
}
else
{
    Console.Write("Max number is ");
    Console.WriteLine(numberOne);
    Console.Write("Min number is ");
    Console.WriteLine(numberTwo);
}
