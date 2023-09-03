// Решение в группах задач:
// 12. Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу
// 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

internal class Program
{
    private static void Main(string[] args)
    {
            Console.WriteLine("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 % num2 == 0)
            {
                Console.WriteLine("Второе число кратно первому");
            }
            else
            {
                int sep = num1 % num2;
                Console.WriteLine("Второе число не кратно первому, остаток: " + sep);
            }
    }
}