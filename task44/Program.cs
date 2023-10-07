int n = 10;
Console.WriteLine("Числа фибоначчи: ");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(Fibonacci(i));
}

int Fibonacci(int number)
{
    if (number <= 1) return number;
    else return Fibonacci(number - 1) + Fibonacci(number - 2);
}