int[,] matrix = new string[3, 4];

void PrintArray (int[,] matr)
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"-{matrix[i, j]}- ");
    }
    Console.WriteLine();
}