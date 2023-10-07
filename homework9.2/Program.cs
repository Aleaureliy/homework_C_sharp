// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int SumFromMToN(int M, int N)
{
    int sum = 0;
    if (M <= N) return M + SumFromMToN(M + 1, N);
    else return sum;
}

int M = Promt("Введите первое число: ");
int N = Promt("Введите второе число: ");
Console.WriteLine(SumFromMToN(M, N));