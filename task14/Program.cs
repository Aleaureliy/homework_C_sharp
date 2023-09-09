// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

double FindDistance(int X1, int Y1, int X2, int Y2)
{
double result = Math.Sqrt(Math.Pow((X2 - X1),2) + Math.Pow((Y2 - Y1),2));
return Math.Round(result,3);
}

int x1 = Promt("Введите координату x1: ");
int x2 = Promt("Введите координату x2: ");
int y1 = Promt("Введите координату x1: ");
int y2 = Promt("Введите координату x2: ");
Console.WriteLine(FindDistance(x1, x2, y1, y2));