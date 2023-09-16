// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Sum(int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10;
        number /= 10;
    }
    return sum;
}

int num = Promt("Введите число: ");
Console.WriteLine(Sum(num));