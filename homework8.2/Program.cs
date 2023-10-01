// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SumRows(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i] += matrix[i, j];
        }
    }
    return result;
}

int MinValueInArray(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

int IndexOf(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value) return i;
    }
    return -1;
}

int[,] matrix = GetArray(3, 4, 1, 10);
Console.WriteLine("Заданный массив: ");
PrintArray(matrix);
int[] array = SumRows(matrix);
Console.WriteLine("\nСумма строк массива:");
Console.WriteLine(String.Join(" ", array));
Console.WriteLine("\nМинимальное значение:");
Console.WriteLine(MinValueInArray(array));
Console.WriteLine("\nСтрока с наименьшей суммой элементов:");
Console.WriteLine(IndexOf(array, MinValueInArray(array)) + " строка.");