// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray(int size, int minValue, int maxValue)  // Метод заполнения массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] GetPairsMultiply(int[] array)
{
    int arrayLength = array.Length;
    // создание массива для перемноженных пар. 
    // Если количество элементов не четное - +1 элемент в новом массиве: 
    int[] pairsMultiply = new int[arrayLength / 2 + arrayLength % 2]; 

    // Заполнение среднего элемента для нечетного количества элементов:
    if (arrayLength % 2 != 0) 
    {
        pairsMultiply[(arrayLength / 2)] = array[(arrayLength / 2)]; 
    }
    // Перемножаем пары в исходном массиве. Резульат вносим в новый массив:
    for (int i = 0; i <= (arrayLength / 2) - 1; i++)
    {
        pairsMultiply[i] = array[i] * array[arrayLength - i - 1];
    }
    return pairsMultiply;
}

int[] givenArray = GetArray(7, 1, 10);
Console.WriteLine($"Массив: [{String.Join("; ", givenArray)}]");
int[] resultArray = GetPairsMultiply(givenArray);
Console.WriteLine($"Массив: [{String.Join("; ", resultArray)}]");