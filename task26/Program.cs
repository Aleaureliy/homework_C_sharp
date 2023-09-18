// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

void ReverseArray1(int[] array) //Первый способ (без создания нового массива)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

int[] ReverseArray2(int[] array) //Второй способ (с созданием второго массива)
{
    int[] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}

int[] array = GetArray(10, 0, 10);
Console.WriteLine(string.Join(", ", array));
ReverseArray1(array);
Console.WriteLine(string.Join(", ", array));
int[] reverseArray = ReverseArray2(array);
Console.WriteLine(string.Join(", ", reverseArray));

// int size = WorkWithUser("Размер массива: ");
// int min = WorkWithUser("Минимальное значение: ");
// int max = WorkWithUser("Максимальное значение: ");
//int[] array = GetArray(size, min, max);