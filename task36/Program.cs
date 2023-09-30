// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

bool Change(int [,] array)
{
    if(array.GetLength(0) == array.GetLength(1)) return true;
    else return false;
}

int[,] ReverseArray(int[,] array)
{
    int[,] result = array;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
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

int[,] array = GetArray(3, 3, -5, 5);
Console.WriteLine("Созданный массив: ");
PrintArray(array);
Console.WriteLine();
if(Change(array))
{
    ReverseArray(array);
    Console.WriteLine("Преобразованный массив: ");
    PrintArray(array);
}
else Console.WriteLine("Ошибка");