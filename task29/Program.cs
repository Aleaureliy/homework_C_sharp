// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Fibonacci(int number)
{
    int first = 0;
    int second = 1;
    Console.Write(first + " ");
    Console.Write(second + " ");
    for(int i = 2; i < number ; i++)
    {
        
        int temp = second + first;
        Console.Write(temp + " ");
        first = second;
        second = temp;
    }
}

int number = Promt("Введите число элементов: ");
Fibonacci(number);