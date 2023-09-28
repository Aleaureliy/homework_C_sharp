// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] GetArray(int row, int colum, int minValue, int maxValue)
{
    int[,] result = new int[row, colum];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colum; j++)
        {
            result[i, j] = rand.Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumOfDiagonal(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
               result += array[i, j];
            }
        }
    }
    return result;
}

int[,] array = GetArray(3, 4, 1, 10);
PrintArray(array);
Console.WriteLine($"Сумма элементов главной диагонали: {SumOfDiagonal(array)}");