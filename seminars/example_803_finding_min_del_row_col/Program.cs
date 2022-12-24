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

/// Метод нахождения индекса минимального элемента матрицы
int[] minValueIndex(int[,] inputMatrix)
{
    int min = int.MaxValue;
    int[] indexArray = { 0, 0 };

    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            if (inputMatrix[i, j] < min)
            {
                min = inputMatrix[i, j];
                indexArray[0] = i;
                indexArray[1] = j;
            }
        }
    }
    return indexArray;
}

/// Метод печати матрицы без заданных строки и столбца
void PrintMatrixWithoutIndex(int[,] inputMatrix, int[] index)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        if (i != index[1])  // Если номер строки не совпадает с номером сроки исключаемого элемента
        {
            for (int j = 0; j < inputMatrix.GetLength(1); j++)
            {
                if (j != index[0])  // Если номер столбца не совпадает с номером столбца исключаемого элемента
                {
                    Console.Write(inputMatrix[i, j] + "\t");
                }
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] newMatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(newMatrix);
Console.WriteLine();
int[] indexOfMin = minValueIndex(newMatrix);
Console.WriteLine($"Array: [{String.Join("; ", indexOfMin)}]");
PrintMatrixWithoutIndex(newMatrix, indexOfMin);