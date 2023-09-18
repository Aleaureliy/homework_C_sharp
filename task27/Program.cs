// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Triangle(int num1, int num2, int num3)
{
    if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num3)
        Console.WriteLine("Треугольник существует");
    else Console.WriteLine("Такого треугольника нет");
}

int num1 = Promt("Введите число 1: ");
int num2 = Promt("Введите число 2: ");
int num3 = Promt("Введите число 3: ");
Triangle(num1, num2, num3);