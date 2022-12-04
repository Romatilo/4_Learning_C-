// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да; 7 -> да; 1 -> нет

Console.Write("Enter weekday number (in the range from 1 to 7) -> ");
int number = Convert.ToInt32(Console.ReadLine());

// Проверка, чтобы введенное число удовлетворяло условию:
while (number < 1 || number > 7)
{
    Console.WriteLine("Week consists of 7 days!");
    Console.Write("Enter day of the week number(in the range from 1 to 7) -> ");
    number = Convert.ToInt32(Console.ReadLine());
}

// Если введенное число 6 или 7 - выходной день:
if (number >= 6)
{
    Console.WriteLine("This is weekend!");
}
else Console.WriteLine("This is weekday.");