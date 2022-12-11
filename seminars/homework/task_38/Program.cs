// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GetArray(int size, int minValue, int maxValue)  // Метод заполнения массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int findMaxNumber(int[] array)
{
    int arrayLength = array.Length;
    int maxNumber = array[0];
    for (int i = 0; i < arrayLength; i++)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
    }
    return maxNumber;
}

int findMinNumber(int[] array)
{
    int arrayLength = array.Length;
    int minNumber = array[0];
    for (int i = 0; i < arrayLength; i++)
    {
        if (array[i] < minNumber) minNumber = array[i];
    }
    return minNumber;
}

int[] givenArray = GetArray(8, -99, 100);
Console.WriteLine($"Массив: [{String.Join("; ", givenArray)}]");
int max = findMaxNumber(givenArray);
int min = findMinNumber(givenArray);
Console.WriteLine($"Разница между максимальным ({max})" +
$"и минимальным({min}) элементами массива составляет {max - min}");