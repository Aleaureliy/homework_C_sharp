Console.Write("Введите двухзначное число: ");
int num = int.Parse(Console.ReadLine());
SecondDigit(num);
void SecondDigit(int number)
{
    if((9 < number < 100) || (-100 < number < -9))
    {
        int secondDigit = (number / 10) % 10;
        Console.WriteLine("Вторая цифра числа: " + secondDigit);
    }
    else
        Console.WriteLine("Введите двухзначное цисло");
}