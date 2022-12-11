// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size,int minValue, int maxValue)  // Метод заполнения массива
{
    int[] array = new int[size]; 
    for (int i = 0; i < size; i++) 
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int CountEven(int [] array)           // Метод подсчета четных чисел массива 
{
    int arrayLength = array.Length;
    int count = 0;
    for (int i = 0; i < arrayLength; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return (count);
}

int[] resultArray = GetArray(10, 0, 999);
Console.WriteLine($"Массив: [{String.Join("; ", resultArray)}]");
Console.WriteLine($"Количество четных чисел массива: {CountEven(resultArray)}");