// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

using System.Diagnostics.Contracts;

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

string Binary(int number)
{
    string result = string.Empty;
    while(number >= 1)
    {   
        result = number % 2 + result;
        number /= 2;
    }
    return result;
}

int BinaryInt(int number)
{
    int binary = 0;
    int count = 1;
    while(number >= 1)
    {
        binary = binary + number % 2 * count;
        count *= 10;
        number /= 2;
    }
    return binary;
}

// int[] BinaryArray(int number)
// {
//     int size = ArrayLength(number);
//     int[] binaryArray = new int[size];
//     for(int i = 0; number > 0; i++)
//     {
//         binaryArray[i] = number % 2;
//         number %= 10;
//     }
//     ReverseBinaryArray(binaryArray);
//     return binaryArray;
// }

// int ArrayLength(int number)
// {
//     int count = 1;
//     while(number > 0)
//     {
//         number %= 2;
//         count ++;
//     }
//     return count;
// }

// int[] ReverseBinaryArray(int[] array)
// {
//     int temp = 0;
//     for(int i = 0; i < array.Length / 2; i++)
//     {
//         temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp;
//     }
//     return array;
// }

int number = Promt("Введите число: ");
Console.WriteLine(Binary(number));
Console.WriteLine(BinaryInt(number));
//string str = Convert.ToString(number, 2);
Console.WriteLine(Convert.ToString(number, 2));
// int number1 = Promt("Введите число: ");
// int[] binaryArray = BinaryArray(number1);
// Console.WriteLine(string.Join("", binaryArray));