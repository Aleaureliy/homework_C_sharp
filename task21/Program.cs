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
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(" ", arr));
}

int size = 12;
int minValue = -9;
int maxValue = 9;
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);

int positiveSum = 0;
int negativeSum = 0;
foreach (int el in array)
{
    if (el > 0) positiveSum += el;
    else negativeSum += el;
}
Console.WriteLine($"{positiveSum}, {negativeSum}");