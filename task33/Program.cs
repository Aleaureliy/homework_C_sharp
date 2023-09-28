// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив  
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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

void TransformArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
               array[i, j] *= array[i, j];
            }
        }
    }
}

int[,] array = GetArray(5, 5, 1, 10);
Console.WriteLine("Оригинальная матрица: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Измененная матрица: ");
TransformArray(array);
PrintArray(array);