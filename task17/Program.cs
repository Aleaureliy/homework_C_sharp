// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

string Promt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    return number;
}
int Counter(string number)
{
    int length = number.Length;
    return length;
}

string num = Promt("Введите число: ");
Console.WriteLine(Counter(num));