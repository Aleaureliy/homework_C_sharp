// Задача №17. Напишите программу, которая принимает на 
// вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.

int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

string FindQuarter(int X, int Y)
{
string result; // == string.Empty
if (X > 0 && Y > 0)
    result ="1 четверть";
else if (X < 0 && Y > 0)
    result ="2 четверть";
else if (X < 0 && Y < 0)
    result ="3 четверть";
else if (X > 0 && Y < 0)
    result ="4 четверть";
else result ="Ошибка!"; // X != 0, Y != 0 (обрарабатываем ошибку).
return result;
}

int x = Promt("Введите координату X: ");
int y = Promt("Введите координату Y: ");
Console.WriteLine(FindQuarter(x, y));