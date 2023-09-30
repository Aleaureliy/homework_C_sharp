// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

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

int[] minArray(int[,] matrix)
{
    int min = matrix[0, 0];
    int[] result = new int[2];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] < min) 
            {
                min = matrix[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int[,] DeleteRowColumn(int[,] matrix, int[] coordinate)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int rowIndex = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        if(i == coordinate[0]) continue;
        int columnIndex = 0;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
                if(j == coordinate[1]) continue;
                    result[rowIndex, columnIndex] = matrix[i, j];
                    columnIndex++;
        }
        rowIndex++;
    }
    return result;
}

void PrintArray(int[,] array)
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

int[,] array = GetArray(3, 4, 1, 10);
PrintArray(array);
int[] min = minArray(array);
int[,] newArray = DeleteRowColumn(array, min);
Console.WriteLine();
PrintArray(newArray);
