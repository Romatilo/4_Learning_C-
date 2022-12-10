// Задача 29: Напишите программу, которая задаёт массив из
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] collection)            // Метод для заполнения массива случайными числами до 10
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 100);
        index++;
    }
}

void PrintArray(int[] col)                  // Метод для выввода массива на экран
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count-1)
    {
        Console.Write(col[position]);
        Console.Write(", ");
        position++;
    }
    Console.Write(col[position] + "]");

}

int arrayLength = 8;
int[] array = new int[arrayLength];
FillArray(array);
Console.WriteLine("Насладитесь вашим массивом из восьми элементов:");
PrintArray(array);