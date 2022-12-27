// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

/// Метод заполнения матрицы случайными цифрами
int[,] GetMatrix(int m, int n, int minValue, int maxValue)  
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}
/// Метод печати матрицы
void PrintMatrix(int[,] inputMatrix)                        
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            Console.Write(inputMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

/// Метод нахождения номера строки с минимальной суммой элементов
int GetMinSumRow(int[,] inputMatrix)
{
    int minSumRow = int.MaxValue;   // Объявляем переменную минимальной суммы строки
    int indexMinSumRow = 0;         // Индекс строки этой переменной
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        int sumRow = 0;             // Переменная суммы строки. Обнуляем для каждой последующей строки
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            sumRow += inputMatrix[i, j];    // Вычисляем сумму i-той строки
        }
        if (sumRow < minSumRow)     // И сравниваем ее значение с суммами других строк.
        {
            minSumRow = sumRow;
            indexMinSumRow = i+1;   // Выведем общепринятый для человеков номер строки.
        }
    }
    return indexMinSumRow;
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] newMatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(newMatrix);
Console.WriteLine("\nНомер строки с минимальной суммой элементов: "  + GetMinSumRow(newMatrix));
