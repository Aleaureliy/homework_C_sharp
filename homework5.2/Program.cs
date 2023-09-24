// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int WorkWithUser(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Sum(int[] array)
{
    int sum = 0;
    int i = 0;
    foreach(int el in array)
    {
        if(i % 2 == 1) sum += array[i];
        i++;
    }
    return sum;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(" ", array));
}

int size = WorkWithUser("Введите размер массива: ");
int min = WorkWithUser("Введите минимальное значение массива");
int max = WorkWithUser("Введите максимальное значение массива");
int[] array = FullArray(size, min, max);
Console.WriteLine("Сумма нечетных эллементов: " + Sum(array));
PrintArray(array);