// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string Binary(int number)
{
    string result = String.Empty;
    while(number >= 1)
    {   
        result = number % 2 + result;
        number /= 2;
    }
    return result;
}

int number = Promt("Введите число: ");
Console.WriteLine(Binary(number));