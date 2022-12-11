// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetArray(int size, int minValue, int maxValue)

{
    int[] array = new int[size]; //Массив на size элементов, заполненных нулями
    for (int i = 0; i < size; i++) // size = array.Length
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int GetCountElements(int[] inputArray, int leftRange, int rightRange)
{
    int count = 0;
    foreach (var item in inputArray)
    {
        if (item >= leftRange && item <= rightRange) count++;
    }
    return count;
}
int[] resultArray = GetArray(123, 0, 1000); // 123 элемента от 0 до 999 включительноэ

Console.WriteLine($"Array: [{String.Join("; ", resultArray)}]");
Console.WriteLine($"Количество элементов в д-е [10;99]: {GetCountElements(resultArray, 10, 99)}");

