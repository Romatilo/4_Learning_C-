// Задача 51. найти сумму элементов главной диагонали

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

int GetSumDiagonal(int[,] inputMatrix)
{
    int sumElements = 0;
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        sumElements += inputMatrix[i, i];
    }
    return sumElements;
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] newMatrix = GetMatrix(rows, columns, 0, 10);
PrintMatrix(newMatrix);
Console.WriteLine(GetSumDiagonal(newMatrix));