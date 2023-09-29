// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

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

void checkArray (int[,] array, int x, int y)
{
    if(x >= 0 && x <= array.GetLength(0) && y >= 0 && y <= array.GetLength(1)) Console.WriteLine($"Элемент по индексам {x} и {y} : {array[x, y]}");
    else Console.WriteLine($"Элемента по индексами {x} и {y} нет.");
}

int[,] array = GetArray(3, 4, -5, 5);
Console.WriteLine("Полученный массив: ");
PrintArray(array);
checkArray(array, 1, 1);