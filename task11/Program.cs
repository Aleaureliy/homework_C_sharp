// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
main(number1, number2);
void main(int num1, int num2)
        {
            if (num1 * num1 == num2 || num2 * num2 == num1)
            {
                Console.Write("да");
            }
            else
            {
                Console.Write("нет");
            }
        }