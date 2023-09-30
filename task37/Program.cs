// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(minValue, maxValue);
        }
    }
    return array;
}

int[] CreateArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count++;
        }
    }
    return array;
}

void PrintArray1(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintArray2(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

void CountElement(int[] array)
{
    int findElement = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == findElement) count++;
        else
        {
            Console.WriteLine($"{findElement} встречается {count} раз.");
            findElement = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{findElement} встречается {count} раз.");
}

int[,] matrix = GetArray(3, 4, 1, 10);
PrintArray1(matrix);
Console.WriteLine();
int[] array = CreateArray(matrix);
SortArray(array);
PrintArray2(array);
Console.WriteLine();
CountElement(array);