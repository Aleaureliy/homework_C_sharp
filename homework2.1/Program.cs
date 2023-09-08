// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
main(number);
void main(int num)
{
    if((99 < num && num < 1000)||(-1000 < num && num < -99))
    Console.WriteLine((num % 100)/10);
    else Console.WriteLine("Введите трехзначное число");
}