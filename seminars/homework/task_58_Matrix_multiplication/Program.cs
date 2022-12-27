// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Две матрицы можно перемножить между собой тогда и только тогда, когда количество 
// столбцов первой матрицы равно количеству строк второй матрицы.
// C[i,j] = Sum(A[i,k]*B[k,j]); - формула перемножения матриц
// Где матрица A имеет размер M х K, матрица B — K х N, и матрица C — M х N.


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
/// Метод проверки возможности перемножения матриц
bool MatrixMultiplicationCheck(int[,] MatrixA, int[,] MatrixB)
{
    int columnsAmountA = MatrixA.GetLength(1);
    int rowsAmountB = MatrixB.GetLength(0);
    return columnsAmountA == rowsAmountB;
}

/// Метод перемножения двух матриц
int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int rowsAmountA = matrixA.GetLength(0);
    int columnsAmountA = matrixA.GetLength(1);
    int columnsAmountB = matrixB.GetLength(1);
    int[,] matrixC = new int[rowsAmountA, columnsAmountB];

    for (int i = 0; i < rowsAmountA; i++)
    {
        for (int j = 0; j < columnsAmountB; j++)
        {
            matrixC[i, j] = 0;

            for (int k = 0; k < columnsAmountA; k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return matrixC;
}

Console.WriteLine("\n" + @"Эта программа для перемножения двух матриц, заполненных случайными числами.  
Задайте размеры матриц. Количество строк первой матрицы должно равняться количеству слобцов второй! 
");
Console.Write("Введите количество строк первой матрицы -->");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы -->");
int columnsA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы -->");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы -->");
int columnsB = Convert.ToInt32(Console.ReadLine());
int[,] newMatrixA = GetMatrix(rowsA, columnsA, 0, 10);
int[,] newMatrixB = GetMatrix(rowsB, columnsB, 0, 10);
Console.WriteLine("\n Первая матрица: ");
PrintMatrix(newMatrixA);
Console.WriteLine("\n Вторая матрица: ");
PrintMatrix(newMatrixB);
Console.WriteLine();
if (MatrixMultiplicationCheck(newMatrixA, newMatrixB))
{
    Console.WriteLine("Матрицы можно перемножить. Вот, что из этого получится:");
    int[,] getMatrixC = MatrixMultiplication(newMatrixA, newMatrixB);
    PrintMatrix(getMatrixC);
}
else Console.WriteLine("Ваши матрицы нельзя перемножить! До свидания.");



