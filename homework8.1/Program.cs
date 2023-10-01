// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] matrix = new int[row, column];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(minValue, maxValue);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int c = 0; c <= matrix.GetLength(0) * matrix.GetLength(1); c++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] < matrix[i, j + 1])
                    {
                        int temp = matrix[i, j + 1];
                        matrix[i, j + 1] = matrix[i, j];
                        matrix[i, j] = temp;
                    }
                }
            }
    }
}

int[,] matrix = GetArray(3, 4, 1, 10);
Console.WriteLine("Изначальный массив: ");
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");
SortArray(matrix);
PrintArray(matrix);