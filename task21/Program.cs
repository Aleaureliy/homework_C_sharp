// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.
int[] GetArray(int length, int min, int max)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {   
        Random rand = new Random();
        result[i] = rand.Next(min, max + 1);
    }
    return result;
}

// void PrintArray(int[] arr)
// {
//     Console.WriteLine(string.Join(" ", arr));
// }

void PrintArray(int[] arr)
{   
    for(int i = 0; i < arr.Length; i++)
    {
    Console.Write(arr[i] + " ");
    }
}

int WorkWithUser(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// void GetSum(int [] array)
// {
// int positiveSum = 0;
// int negativeSum = 0;
// foreach (int el in array)
// {
//     if (el > 0) positiveSum += el;
//     else negativeSum += el;
// }
// Console.WriteLine($"Сумма положительных чисел: {positiveSum}, сумма отрицательных: {negativeSum}");
// }

int[] GetSum(int[] array)
{
    int[] result = new int[2];
    foreach(int el in array)
    {
        if(el > 0) result[0] += el;
        else result[1] += el;
    }
    return result;
}

int size = WorkWithUser("Введите размер массива");
int minValue = WorkWithUser("Введите минимальное значение массива");
int maxValue = WorkWithUser("Введите максимальное значение массива");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
// GetSum(array);
int[] result = GetSum(array);
Console.WriteLine($"Сумма положительных чисел: {result[0]}, сумма отрицательных: {result[1]}");