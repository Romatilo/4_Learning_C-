// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] GetArray(int size,int minValue, int maxValue)
 // size - размер массива, minValue - минимальное число (-9), maxValue - (9)
{
    int[] array = new int[size]; //Массив на size элементов, заполненных нулями
    for (int i = 0; i < size; i++) // size = array.Length
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
// Вызов функции
int[] resultArray = GetArray(12, -9, 9);
Console.WriteLine($"Array: [{String.Join("; ", resultArray)}]");

int[] InverseArray(int[] array)
{
    int size = array.Length; // size = array.Length (длина массива)
    for (int i = 0; i < size; i++)
    {
        array[i] *= (-1); // array[i] = array[i] * (-1)
    }
    return array;

}
 
Console.WriteLine($"Reverse array: [{String.Join("; ", InverseArray(resultArray))}]");