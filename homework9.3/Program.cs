// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int AckermannFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return AckermannFunction(m - 1, 1);
    else
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

int m = Promt("Введите первое число: ");
int n = Promt("Введите второе число: ");
Console.WriteLine(AckermannFunction(m, n));