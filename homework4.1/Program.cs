// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Cube(int number1, int number2)
{
    int result = number1;
    for(int i = 1; i < number2; i++)
    {
        result *= number1;
    }
    return result;
}

int num1 = Promt("Введите первое число: ");
int num2 = Promt("Введите второе число: ");
Console.WriteLine(Cube(num1, num2));