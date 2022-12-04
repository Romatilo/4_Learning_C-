//Напишите программу, которая выводит случайное число из 
// отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Введите первое число диапазона, но не меньше 0!");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число диапазона, но не больше 100!");
int end = Convert.ToInt32(Console.ReadLine());
int number = new Random().Next(start, end);

Console.WriteLine("Ваше число: " + number);

int firstDigit = number / 10;
int secondDigit = number % 10;

int max = firstDigit;
if (secondDigit > max)
{
    max = secondDigit;
}
System.Console.WriteLine("Максимальное число: " + max);