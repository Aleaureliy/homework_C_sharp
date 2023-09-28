// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int WorkWithUser(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int[,] GetArray(int row, int colum, int minValue, int maxValue)
{
int[,] result = new int[row, colum];
Random rand = new Random();
for(int i = 0; i < row; i++)
{
    for(int j = 0; j < colum; j++)
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

int rows = WorkWithUser("Введите кол-во строк: ");
int columns = WorkWithUser("Введите кол-во столбцов: ");
int min = WorkWithUser("Введите минимальное значение: ");
int max = WorkWithUser("Введите максимальное: ");
int[,] array = GetArray(rows, columns, min, max);
PrintArray(array);