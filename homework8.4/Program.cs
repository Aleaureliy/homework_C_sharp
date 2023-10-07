// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetArray(int index1, int index2, int index3, int minValue, int maxValue)
{
    int[,,] matrix = new int[index1, index2, index3];
    Random rand = new Random();
    for (int i = 0; i < index1; i++)
    {
        for(int k = 0; k < index2; k++)
        {
            for (int j = 0; j < index3; j++)
            {
                matrix[i, k, j] = rand.Next(minValue, maxValue);
            }
        }
    }
    return matrix;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                Console.WriteLine($"{array[i, k, j]} ({i} {k} {j})");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] array = GetArray(2, 2, 2, 10, 100);
PrintArray(array);