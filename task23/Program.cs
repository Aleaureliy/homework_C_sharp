// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.

int[] GetArray(int length, int min, int max)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

bool FindNum(int number, int[] array)
{
    bool result = false;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == number) return true;
    }
    return result;
}

int WorkWithUser(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}

int size = WorkWithUser("Размер массива: ");
int min = WorkWithUser("Минимальное значение: ");
int max = WorkWithUser("Максимальное значение: ");
int number = WorkWithUser("Максимальное число для поиска: ");
int[] array = GetArray(size, min, max);
if (FindNum(number, array)) Console.WriteLine("да");
else Console.WriteLine("нет");
PrintArray(array);