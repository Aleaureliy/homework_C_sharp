// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в
// промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

string FromNToOne(int number)
{
    if(number > 1) return $"{number} " + FromNToOne(number - 1);
    else return $"{1}";
}

int number = Promt("Введите натуральное число: ");
Console.WriteLine(FromNToOne(number));