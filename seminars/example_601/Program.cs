// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] GetArray(int size, int minValue, int maxValue)  // Метод заполнения массива
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] array = GetArray(6, 0, 10);

// 1. С помощью for заполняем массив справа налево
int[] CopyReverseArray(int[] array)
{
    int[] result = new int[array.Length]; 
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length-i-1];
    }
    return result;
}


// 2. Метод пузырька
void BubbleSort(int[] array)
{
    int size = array.Length;
    int last = size - 1;
    for (int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[last - i];
        array[last - i] = temp;
    }
}

int[] givenArray = GetArray(16, 1, 10);
Console.WriteLine($"Массив: [{String.Join("; ", givenArray)}]");
int[] resultArray = CopyReverseArray(givenArray);
Console.WriteLine($"Массив: [{String.Join("; ", resultArray)}]");
Console.WriteLine($"Массив: [{String.Join("; ", BubbleSort(givenArray))})]");