// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет; 12821 -> да; 23432 -> да

Console.Write("Enter number in the range from 10000 to 99999 -> ");
int number = Convert.ToInt32(Console.ReadLine());

// Проверка, чтобы введенное число удовлетворяло условию:
while (number < 10000 || number > 99999)            
{
    Console.WriteLine("The number you've entered is out of range!");
    Console.Write("Enter number in the range from 10000 to 99999 -> ");
    number = Convert.ToInt32(Console.ReadLine());
}

// Записываем цифры числа в отдельные переменные
int firstDigit = number / 10000;
int secondDigit = number % 10000 / 1000;
int thirdDigit = number % 1000 / 100;
int fourthDigit = number % 100 / 10;
int fifthDigit = number % 10;
int reverseNumber = (fifthDigit*10000 + fourthDigit*1000 + thirdDigit*100 + secondDigit*10 + firstDigit);

// Проверяем, является ли число палиндромом:
if (reverseNumber == number)
{
    Console.WriteLine($"The number {number} IS palindrome");
}
else Console.WriteLine($"The number {number} IS NOT palindrome");
