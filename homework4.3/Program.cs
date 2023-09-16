// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] GenerateArray(int length, int min, int max)
{
    int[] array = new int[length];
    Random random = new Random();
    for(int i = 0; i < length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(" ", arr));
}

int length = Promt("Введите длинны массива: ");
int min = Promt("Введите минимальное значение массива: ");
int max = Promt("Введите максимальное значение массива: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);