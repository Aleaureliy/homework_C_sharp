// Задача 61: Вывести первые N строк треугольника
// Паскаля. Сделать вывод в виде равнобедренного
// треугольника

int[,] Triangle(int number)
{
    int[,] triangle = new int[number, number];
    triangle[0, 0] = 1;
    for (int i = 0; i < number; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            if (j == 0 || i == j) triangle[i, j] = 1;
            else triangle[i, j] = triangle[i - 1, j] + triangle[i - 1, j - 1];
        }
    }
    return triangle;
}

void PrintTriangle(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0) Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void PrintTriangle2(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            Console.Write(" ");
        }
        int number = 1;
        for (int j = 0; j <= i; j++)
        {
            Console.Write(number + " ");
            number = number * (i - j) / (j + 1);
        }
        Console.WriteLine();
    }
}

int[,] array = Triangle(5);
PrintTriangle(array);
Console.WriteLine();
PrintTriangle2(5);