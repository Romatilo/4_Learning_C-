// Здача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
