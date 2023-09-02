// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

// int num = int.Parse(Console.ReadLine()!);
// int result = num % 10;
// Console.WriteLine(result);

Console.WriteLine("Введите трехзначное число: ");
int value = Convert.ToInt32(Console.ReadLine());
if(value < 1000)
{
    int lastValue = value % 10;
    Console.WriteLine("Последняя цифра трёхзначного числа: " + lastValue);
}
else
    Console.WriteLine("Введите трехзначное число");
