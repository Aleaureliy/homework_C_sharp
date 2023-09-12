// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];

// for(int i = 0; i < array.Length; i ++)
// {
//     array[i] = new Random().Next(0, 2);
//     Console.Write($"{array[i]} ");
//     Console.WriteLine();
// }

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
    {
        array[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] collection)
{
    for(int i = 0; i < collection.Length; i++)
    {
        // Console.Write($"{collection[i]} ");
        Console.Write(collection[i] + " ");
        // Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);