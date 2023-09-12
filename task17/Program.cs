// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// string Promt(string message)
// {
//     Console.Write(message);
//     string number = Console.ReadLine();
//     return number;
// }
// int Counter(string number)
// {
//     int length = number.Length;
//     return length;
// }

// string num = Promt("Введите число: ");
// Console.WriteLine(Counter(num));

int Promt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int Numbers(int number)
{
    int count = 0;
    int num = Math.Abs(number); // Убираем значение для отрицательного числа
    if(num ==0) return 1;
    while(num > 0)
    {
        count ++;
        num /= 10;
    }
    return count;
}

int num = Promt("Введите число: ");
Console.WriteLine(Numbers(num));