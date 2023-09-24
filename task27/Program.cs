// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void TriangleVoid(int num1, int num2, int num3)
{
    if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num1) Console.WriteLine("Треугольник существует");
    else Console.WriteLine("Такого треугольника нет");
}

bool TriangleBool(int num1, int num2, int num3)
{
    bool result = false;
    if(num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) result = true;
    return result;
}

int num1 = Promt("Введите число 1: ");
int num2 = Promt("Введите число 2: ");
int num3 = Promt("Введите число 3: ");
Console.WriteLine();
TriangleVoid(num1, num2, num3);
Console.WriteLine();
if (TriangleBool(num1, num2, num3)) Console.WriteLine("Треугольник существует");
else Console.WriteLine("Такого треугольника нет");