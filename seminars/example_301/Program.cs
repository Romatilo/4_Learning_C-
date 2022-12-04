// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите первое число > ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число > ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
{
    Console.WriteLine("Точка в первой четверти");
}
else if (x<0 && y>0) Console.WriteLine("Точка во второй четверти");
else if (x<0 && y<0) Console.WriteLine("Точка в третьей четверти");
else if (x>0 && y<0) Console.WriteLine("Точка в четвертой четверти");
else Console.WriteLine("вы в начале координат!");
