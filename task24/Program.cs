// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99]. 

// int[] GetArray(int length, int min, int max)
// {
//     int[] result = new int[length];
//     for (int i = 0; i < result.Length; i++)
//     {
//         result[i] = new Random().Next(min, max + 1);
//     }
//     return result;
// }

// void PrintArray(int[] arr)
// {
//     Console.WriteLine(string.Join(" ", arr));
// }

// int WorkWithUser(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine());
//     return num;
// }

// int size = WorkWithUser("Размер массива: ");
// int min = WorkWithUser("Минимальное значение: ");
// int max = WorkWithUser("Максимальное значение: ");

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 124);
    }
}
int CountNumArray(int min, int max, int[] collection)
{
    int res = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if(collection[i] >= min && collection[i] <= max) res +=1;
    }
    return res;
}
void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(" ", arr));
}

int size = 10;
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);
int count = CountNumArray(10, 99, numbers);
Console.WriteLine(count);