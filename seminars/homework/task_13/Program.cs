// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5; 78 -> третьей цифры нет: 32679 -> 6

Console.Write("Enter your number -> ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = 0;
if (number / 100 < 1)               // Проверяем, если число меньше 100
{
    Console.WriteLine ("There is no 3rd digit in your number!");   
}
else
{
    while (number / 100 >= 1)     
{
    thirdDigit = number % 10;      // (запоминаем последнее число)
    number = number / 10;          // (отбрасываем последнее число)
}
    Console.WriteLine("The third digit of you number is: " + thirdDigit); 
}