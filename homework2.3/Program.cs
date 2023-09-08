// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
// string day = Console.ReadLine();
int day = int.Parse(Console.ReadLine()!);
week(day);
//void week(string i)
void week(int i)
{
    if (i < 6 && i >= 1)
        Console.WriteLine("нет");
    else if (i == 6 || i == 7)
        Console.WriteLine("да");
    else Console.WriteLine("Ведите номер дня недели!");
    // switch(i)
    // {
    //     case "1":
    //         Console.WriteLine("нет");
    //         break;
    //     case "2":
    //         Console.WriteLine("нет");
    //         break;
    //     case "3":
    //         Console.WriteLine("нет");
    //         break;
    //     case "4":
    //         Console.WriteLine("нет");
    //         break;
    //     case "5":
    //         Console.WriteLine("нет");
    //         break;
    //     case "6":
    //         Console.WriteLine("да");
    //         break;
    //     case "7":
    //         Console.WriteLine("да");
    //         break;
    //     default:
    //         Console.WriteLine("Введите номер дня недели!");
    //         break;
    // }
}
