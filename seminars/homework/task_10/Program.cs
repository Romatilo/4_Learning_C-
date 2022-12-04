// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа. 
// 456 -> 5; 782 -> 8; 918 -> 1

Console.Write("Enter number in the range from 100 to 999 -> ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 100 || number > 999)
{
    Console.WriteLine("The number you've entered is out of range!");
    Console.Write("Enter number in the range from 100 to 999 -> ");
    number = Convert.ToInt32(Console.ReadLine());
}
int secondDigit = number % 100 / 10;
Console.WriteLine("Second digit of your number is " + secondDigit);