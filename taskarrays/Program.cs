// Создать два одинаковых массива
// Перемножить их поэлементно и записать результат в новый массив

// int WorkWithUser(string message)
// {
//     Console.WriteLine(message);
//     int number = int.Parse(Console.ReadLine());
//     return number;
// }

int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    Random rand = new Random();
    int[,] result = new int[row, column];
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = rand.Next(minValue, maxValue);
        }
    }
    return result;
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

int[,] Multiplication(int[,] array1, int[,] array2)
{
    int[,] matrix = new int[array1.GetLength(0), array1.GetLength(1)];
    for(int i = 0; i < array1.GetLength(0); i++)
    {
        for(int j = 0; j < array1.GetLength(1); j++)
        {
            matrix[i, j] = array1[i, j] * array2[i, j]; 
        }
    }
    return matrix;
}

int[,] array1 = GetArray(3, 4, 1, 10);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(3, 4, 1, 10);
PrintArray(array2);
Console.WriteLine();
int[,] result = Multiplication(array1, array2);
PrintArray(result);