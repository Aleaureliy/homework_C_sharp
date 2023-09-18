// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FullArray(int size, int min, int max)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        Random rand = new Random();
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

int Count (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(" ", array));
}

int size = WorkWithUser("Введите размер массива: ");
// int min = WorkWithUser("Введите минимальное значение массива: ");
// int max = WorkWithUser("Введите максимальное значение массива: ");
int min = 100;
int max = 999;
int[] array = FullArray(size, min, max);
Console.WriteLine("Число четных эллементов в массиве: " + Count(array));
PrintArray(array);