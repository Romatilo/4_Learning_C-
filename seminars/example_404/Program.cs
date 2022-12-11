// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

/*
void FillArray(int[] collection)            // Метод для заполнения массива случайными числами до 10
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] col)                  // Метод для выввода массива на экран
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        Console.Write(" ");
        position++;
    }

}
/*
int[] array = new int[8];
FillArray(array);
Console.WriteLine("Насладитесь вашим массивом:");
PrintArray(array);

int[] array = new int[8];
FillArray(array);
PrintArray(array);
Console.WriteLine();
foreach (int i in array)
{
    Console.Write(i);
}
*/

int n = 8;
int[] arr = new int[n];
foreach (int i in arr)
{
    arr[i] = new Random().Next(0, 2);
}
Console.WriteLine(string.Join(", ", arr));