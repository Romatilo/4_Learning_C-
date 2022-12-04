void FillArray(int[] collection)            // Метод для заполнения массива случайными числами до 10
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
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
        Console.Write("    ");
        position++;
    }

}

int IndexOf(int[] collection, int find)     // Метод для поиска требуемого числа в массиве
{
    int lengthIndex = collection.Length;
    int index = 0;
    int position = -1;
    while (index < lengthIndex)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

Console.Write("Введите количество элементов массива > ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, которое вы хотите найти в массиве > ");
int findNumber = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

FillArray(array);
Console.WriteLine("Насладитесь вашим массивом:");
PrintArray(array);
Console.WriteLine();
Console.Write($"Искомый элемент впервые встречается в следующем элементе массива: ");
Console.WriteLine(IndexOf(array, findNumber));