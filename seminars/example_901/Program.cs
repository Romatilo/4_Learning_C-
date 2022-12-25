
int[,] GetOneCycleMatrix(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < rows * columns; i++)
    {
        array[i / columns, i % columns] = new Random().Next(11);
    }
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

int[,] matrix = GetOneCycleMatrix(3, 3);
PrintMatrix(matrix);