﻿// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void FindQuarter(int number)
{
    int index = 1;
    while(index <= number)
    {
        Console.WriteLine(index * index);
        index++;
    }
}
int num = Promt("Введите число: ");
FindQuarter(num);