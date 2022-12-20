// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetMatrix(int m, int n, int minValue, int maxValue)  // Метод заполнения матрицы случайными цифрами
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

void PrintMatrix(int[,] inputMatrix)                        // Метод печати матрицы
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

double[] AverageColumns(int[,] inputMatrix)      // Метода нахождения среднего арифметического каждлого столбца
{
    int rowsLength = inputMatrix.GetLength(0);
    int columnsLength = inputMatrix.GetLength(1);
    double[] arrayAverage = new double[columnsLength];
    for (int j = 0; j < columnsLength; j++)   // Для удобства восприятия перебор по столбцу сделал через j
    {
        double sumColumn = 0;          // сумму чисел столбца обнуляем перед каждым столбцом
        for (int i = 0; i < rowsLength; i++)
        {
            sumColumn += inputMatrix[i, j];
        }
        arrayAverage[j] = Math.Round((sumColumn / rowsLength), 2);
    }
    return arrayAverage;
}

int rows = new Random().Next(2, 5);          // немного разнообразия при 
int columns = new Random().Next(2, 7);       // формировании матрицы ;-)
int[,] matrix = GetMatrix(rows, columns, 1, 10);
Console.WriteLine("Ваша матрица:");
PrintMatrix(matrix);
Console.WriteLine("Среднее арифметическое каждого столбца");
Console.WriteLine($"{String.Join("\t", AverageColumns(matrix))}");
