// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
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

int BinaryInt(int number)
{
    int binary = 0;
    int count = 1;
    while(number >= 1)
    {
        binary = binary + number % 2 * count;
        count *= 10;
        number /= 2;
    }
    return binary;
}

int number = Promt("Введите число: ");
Console.WriteLine(Binary(number));
Console.WriteLine(BinaryInt(number));
//string str = Convert.ToString(number, 2);
Console.WriteLine(Convert.ToString(number, 2));