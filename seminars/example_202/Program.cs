//Напишите программу, которая выводит случайное трёхзначное число и удаляет
// вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

int start = 100;
int end = 1000;
int number = new Random().Next(start, end);
Console.WriteLine(number);

int firstDigit = number /100;
int thirdDigit = number % 10;

Console.WriteLine(firstDigit*10 + thirdDigit);