//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деление. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно


Console.WriteLine("Введите первое число > ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число > ");
int second = Convert.ToInt32(Console.ReadLine());

int devision = second % first;
if (devision == 0)
{
    Console.WriteLine("Число 1 кратно числу 2");
}
else
{
        Console.WriteLine("Число 1 не кратно числу 2, остаток от деления = " + devision);
}