/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
             является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Enter your number");                 // Запрос числа
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)                                    // Проверка числа на четность
{
    Console.Write("Your number is ");                  
    Console.WriteLine("EVEN");
}
else
{
    Console.Write("Your number is ");
    Console.WriteLine("UNEVEN");;
}
