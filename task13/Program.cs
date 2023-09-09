// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).

int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

string Quarter(int number)
{
string result; // == string.Empty
if (number == 1)
    result ="X > 0, Y > 0.";
else if (number == 2)
    result ="X < 0, Y > 0.";
else if (number == 3)
    result ="X < 0, Y < 0.";
else if (number == 4)
    result ="X > 0, Y < 0.";
else result ="Ошибка!";
return result;
}

int num = Promt("Введите номер четверти от 1 до 4: ");
Console.WriteLine(Quarter(num));