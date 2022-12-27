// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


/// Метод заполнения квадратной матрицы размера n x n по спирали 
int[,] GetMatrix(int n)
{
    int[,] matrix = new int[n, n];
    int count = 0;  // счетчик количества заполненных ячеек матрицы
    int i = 0; int j = 0;    
    for (j = 0; j < n; j++)  // заполнение первой (i = 0) строки 
    {
        count++;
        matrix[i, j] = count;
    }
    i = 0;
    j = n - 1; // остаемся на крайнем правом столбике
    int numberElements = n * n; // число элементов матрицы
    while (count < numberElements){ 
    // условие выхода из цикла - количество заполненных ячеек = количеству ячеек в матрице
        for (int k = 0; k < n - 1; k++)  // движение вниз
        {
            i++;
            count++;
            matrix[i, j] = count;
        }
        for (int k = 0; k < n - 1; k++)  // движение влево
        {
            j--;
            count++;
            matrix[i, j] = count;
        }
        for (int k = 0; k < n - 2; k++)  // движение вверх
        {
            i--;
            count++;
            matrix[i, j] = count;
        }
        for (int k = 0; k < n - 2; k++)  // движение вправо
        {
            j++;
            count++;
            matrix[i, j] = count;
        }
        n = n - 2;    // переход на внутренний виток
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

Console.WriteLine("Введите размер квадратной матрицы (количество строк)");
int size = Convert.ToInt32(Console.ReadLine());
int[,] newMatrix = GetMatrix(size);
PrintMatrix(newMatrix);