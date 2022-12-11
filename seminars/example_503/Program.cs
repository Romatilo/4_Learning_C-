// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

/*int[] array = { 1, 2, 3, 4, 5, 6, 7 };

int searchNumber = new Random().Next(1, 11); // [1;10]

Console.WriteLine($"Ищем число {searchNumber} в массиве..");

int size = array.Length;

bool result = false; // false = число в массиве НЕ найдено
// true = число в массиве найдено

for (int i = 0; i < size; i++)
{
    if (searchNumber == array[i])
    {
        result = true; // element found
        break;
    }
}
// if (result == true)
if (result) Console.WriteLine($"Элемент {searchNumber} в массиве найден");
else Console.WriteLine($"Элемент {searchNumber} в массиве НЕ найден");
*/

int[] array = { 1, 2, 3, 4, 5, 6, 7 };
int searchNumber = new Random().Next(1, 11); // [1;10]
Console.WriteLine($"Ищем число {searchNumber} в массиве..");
int size = array.Length;
string result = "отсутствует"; // false = число в массиве НЕ найдено
// true = число в массиве найдено
for (int i = 0; i < size; i++)
{
    if (searchNumber == array[i])
    {
        result = "присутствует"; // element found
        break;
    }
}
// if (result == true)
Console.WriteLine($"Элемент {searchNumber} в массиве: {result}");
