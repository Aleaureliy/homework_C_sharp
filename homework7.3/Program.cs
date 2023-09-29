// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    Random rand = new Random();
    int[,] array = new int[row, column];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray1 (int[,] array)
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

void PrintArray2 (double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i].ToString("F2") + "\t");
    }
}

double[] SumArray(int[,] array)
{
    int size = array.GetLength(1);
    double[] result = new double[size];
    double sum = 0.0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        double temp = 0.0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
            temp = temp + array[j, i];
        }
        sum = temp / array.GetLength(0);
        result[i] = sum;
    }
    return result;
}

int[,] matrix = GetArray(3, 3, -5, 5);
Console.WriteLine("Созданный массив: ");
PrintArray1(matrix);
double[] array = SumArray(matrix);
Console.WriteLine("Среднее арифметическое столбцов: ");
PrintArray2(array);