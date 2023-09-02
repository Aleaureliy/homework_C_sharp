// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введенное число: ");
Console.WriteLine(number);
Console.Write("1. Квадрат числа: ");
Console.WriteLine(number * number);
Console.WriteLine("2. Квадрат числа : " + (number * number));
int result = number * number;
Console.WriteLine("3. Квадрат числа : " + result);