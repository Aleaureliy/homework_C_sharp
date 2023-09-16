// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.

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

int WorkWithUser(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void Opposite(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i] * -1;
    }
}

int size = WorkWithUser("Размер массива: ");
int min = WorkWithUser("Минимальное значение: ");
int max = WorkWithUser("Максимальное значение: ");
int[] array = GetArray(size, min, max);
PrintArray(array);
Opposite(array);
Console.WriteLine();
PrintArray(array);