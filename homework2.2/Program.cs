// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
main(number);

void main(int num)
{
    if(num > 99 || num < -99)
        {
            while(num > 999 || num < -999)
            {
                num = num / 10;
            }
            num = num % 10;
            Console.WriteLine(num);
        }
    else Console.WriteLine("Третьей цифры нет");
}