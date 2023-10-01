// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] matrixOne, int[,] matrixTwo)
{
    if(matrixOne.GetLength(0) != matrixTwo.GetLength(1)) Console.WriteLine("Умножение невозможно.");
    int[,] result = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = 0;
            for(int k = 0; k < matrixOne.GetLength(1); k++)
            {
                result[i, j] += matrixOne[i, k] * matrixTwo[k, j];
            }
        }
    }
    return result;
}

int[,] matrixOne = GetArray(3, 3, 1, 10);
Console.WriteLine("Первая матрица: ");
PrintArray(matrixOne);
int[,] matrixTwo = GetArray(3, 3, 1, 10);
Console.WriteLine("Вторая матрица: ");
PrintArray(matrixTwo);
Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
PrintArray(MatrixMultiplication(matrixOne, matrixTwo));