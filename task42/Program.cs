// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

int SumOfDigit(int number)
{
    if(number == 0) return number;
    else return number % 10 + SumOfDigit(number / 10);
}
Console.WriteLine(SumOfDigit(4));
