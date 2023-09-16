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

bool FindNum(int number, int[] collection)
{
    bool res = false;
    for(int i = 0; i < collection.Length; i++)
    {
        if(collection[i] == number) return true;
    }
}

int WorkWithUser(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int size = WorkWithUser("Размер массива: ");
int min = WorkWithUser("Минимальное значение: ");
int max = WorkWithUser("Максимальное значение: ");
int[] array = GetArray(size, min, max);
if (FindNum(num, array))