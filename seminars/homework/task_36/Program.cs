// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)  // Метод заполнения массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int SumUnEvenPos(int[] array)    // Метод подсчета суммы элементов массива, стоящих на нечетных позициях 
// сделал это метод универсальным: при нечетном количестве элементов цикл будет уходить 
// за границу элементов массива
{
    int arrayLength = array.Length;
    int sum = 0;
    if (arrayLength % 2 == 0)
    {
        for (int i = 1; i <= arrayLength; i = i + 2) sum += array[i];
    }
    else for (int i = 1; i < arrayLength; i = i + 2) sum += array[i];

    return (sum);
}

int[] resultArray = GetArray(5, 0, 99);
Console.WriteLine($"Массив: [{String.Join("; ", resultArray)}]");
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях: {SumUnEvenPos(resultArray)}");