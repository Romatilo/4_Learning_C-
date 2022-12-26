// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


/// Метод заполнения матрицы по спирали
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

/// Метод сортировки пузьком от большего к меньшему
void BubbleSortReverse(int[,] inputMatrix)
{
    int rowsAmount = inputMatrix.GetLength(0);
    int columnsAmount = inputMatrix.GetLength(1);
    for (int i = 0; i < rowsAmount; i++) //  Проходим по каждой строке
    {
        for (int j = 0; j < (columnsAmount - 1); j++)   // По каждому элементу строки, кроме последнего
        {
            for (int k = 0; k < (columnsAmount - 1 - j); k++) // цикл сравнения соседних элементов
            // "-j" - чтобы не делать лишних сравнений для уже отсортированной части строки массива
            {
                if (inputMatrix[i, k] < inputMatrix[i, k + 1])  //Сравниваем соседние элементы и меняем местами, если нужно
                {
                    int temp = inputMatrix[i, k + 1];
                    inputMatrix[i, k + 1] = inputMatrix[i, k];
                    inputMatrix[i, k] = temp;
                }
            }
        }
    }

}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] newMatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(newMatrix);
BubbleSortReverse(newMatrix);
Console.WriteLine("Отсортированная матрица: ");
PrintMatrix(newMatrix);
