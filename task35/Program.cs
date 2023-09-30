// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];
    Random rand = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(int[,] array)
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

void ReverseRow1(int[,] array)
{
    for(int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
}

int[,] ReverseRow2(int[,] array)
{
    int[,] result = array;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        int temp = result[0, i];
        result[0, i] = result[result.GetLength(0) - 1, i];
        result[result.GetLength(0) - 1, i] = temp;
    }
    return result;
}

int[,] matrix = GetArray(3, 4, -5, 5);
PrintArray(matrix);
Console.WriteLine();
ReverseRow1(matrix);
PrintArray(matrix);
Console.WriteLine();
int[,] newMatrix = ReverseRow2(matrix);
PrintArray(newMatrix);