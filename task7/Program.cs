int num = new Random().Next(10, 100);
Console.WriteLine(num);
FindMaxDigit(num);

void FindMaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    Console.WriteLine($"{firstDigit}, {secondDigit}");
    if (firstDigit > secondDigit)
        Console.WriteLine(firstDigit);
    else if (firstDigit == secondDigit)
        Console.WriteLine("Цифры равны");
    else
        Console.WriteLine(secondDigit);
}