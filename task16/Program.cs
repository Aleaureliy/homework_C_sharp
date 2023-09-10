// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int FindSum(int number)
{
    int sum = 0;
    for(int i = 1; i <= number; i++)
        {
            sum += i;
        }
    return sum;
}

int num = Promt("Введите число А: ");
Console.WriteLine(FindSum(num));