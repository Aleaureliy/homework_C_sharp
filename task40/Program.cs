// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}
void ShowNumbers(int number)
{
    if (number == 1) Console.Write(1 + " "); // Принудительное завершение метода;
    else
    {
        ShowNumbers(number - 1);
        Console.Write(number + " ");
    }
}
string ShowNumbers1(int number)
{
    if (number == 1) return "1";
    else return $"{ShowNumbers1(number - 1)} {number}";
}
Console.Clear();
int number = Promt("Введите число: ");
Console.WriteLine(ShowNumbers1(number));
ShowNumbers(number);