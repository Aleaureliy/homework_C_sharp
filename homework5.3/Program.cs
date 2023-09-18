// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] FullArray(int size)
{
    double[] array = new double[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
        {
        array[i] = random.NextDouble() * 100;
        }
    return array;
}

void PrintArray(double[] array)
{
        foreach (double element in array)
        {
            Console.Write($"{element:0.00} ");
        }
        Console.WriteLine();
}

int WorkWithUser(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double Difference(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length - 1; i++)
    {
        if(min > array[i + 1]) min = array[i + 1];
    }
    for(int i = 0; i < array.Length - 1; i++)
    {
        if(max < array[i + 1]) max = array[i + 1];
    }
    double result = max - min;
    return result;
}

int size = WorkWithUser("Введите размер массива: ");
// int min = WorkWithUser("Введите минимальный элемент массива: "); 
// int max = WorkWithUser("Введите минимальный элемент массива: ");
double[] array = FullArray(size);
PrintArray(array);
double result = Difference(array);
Console.WriteLine($"{result:0.00}");