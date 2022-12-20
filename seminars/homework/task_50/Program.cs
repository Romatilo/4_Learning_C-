// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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

int rows = new Random().Next(1, 10);        // Элемент игры - пусть пользователь не знает 
int columns = new Random().Next(1, 10);     // какого размера матрица
int[,]matrix = GetMatrix(rows, columns, 0, 10);

Console.WriteLine("Через пробел введите индекс матрицы (i j)");
int[] array = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).ToArray(); 
if (array[0] < rows && array[1] < columns)
{
    Console.WriteLine($"Запрошенный элемент матрицы имеет значение: {matrix[array[0],array[1]]}");
}
else Console.WriteLine("Запрошенный вами элемент за пределами матрицы!");

Console.WriteLine("Узрите же матрицу, созданную богом Рандома! ");
PrintMatrix(matrix);