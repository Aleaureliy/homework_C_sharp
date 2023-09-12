// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Factorial(int number)
{
    int res = 1;
    for(int i = 1; i <= number; i++)
    {   
        res *=i;
    }
    return res;
}

int num = Promt("Введите число: ");
Console.WriteLine(Factorial(num));