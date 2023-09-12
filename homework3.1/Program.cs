using System;
public class Answer
{
    static bool IsPalindrome(int number)
    {
      // Введите свое решение ниже
        if(number < 9999 || number > 99999)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }
        // int reverse = 0;
        // int temp = number;
        // while (temp > 0)
        // {
        //     reverse = reverse * 10 + temp % 10;
        //     temp /= 10;
        // }
        // return reverse == number;
        else
        return ((number % 10 == number / 10000) && ((number / 10 % 10) == (number / 1000 % 10)));
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 63236;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}