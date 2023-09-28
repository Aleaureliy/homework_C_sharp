// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double[,] GetArray(int row, int colum)
{
double[,] result = new double[row, colum];
Random rand = new Random();
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < colum; j++)
        {
            result[i,j] = Math.Round(rand.NextDouble() * 10 - 5, 2);
        }
    }
return result;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] array = GetArray(3, 4);
PrintArray(array);