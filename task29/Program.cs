// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int Promt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine()!);
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

int[] Fibonacci1(int number)
{
    int[] result = new int[number];
    result[0] = 0;
    result[1] = 1;
    for(int i = 2; i < result.Length; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
    }
    return result;
}

int number = Promt("Введите число элементов: ");
Fibonacci(number);
Console.WriteLine();
int [] result = Fibonacci1(number);
Console.WriteLine(string.Join(" ", result));