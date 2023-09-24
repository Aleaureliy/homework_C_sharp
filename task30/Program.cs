// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rand.Next(minValue, maxValue);
    }
    return result;
}

int[] NewArray(int[] array)
{
    int[] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.Write("{");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "}");
}

int[] array = GetArray(10, 0, 10);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", NewArray(array)));
PrintArray(array);