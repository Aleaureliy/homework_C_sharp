// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8" 

string ShowNumbers(int M, int N)
{
    if (M <= N) return $"{M} " + ShowNumbers(M + 1, N);
    else return string.Empty;
}
string ShowNumbers1(int a, int b)
{
    if(a < b) return $"{a} " + ShowNumbers1(a + 1, b);
    else return $"{b}";
}
void GenerateNumbers(int start, int end)
{
    if (start > end) return;
    Console.Write(start + " ");
    GenerateNumbers(start + 1, end);
}
Console.Clear();
Console.WriteLine(ShowNumbers(1, 10));
GenerateNumbers(10, 20);
Console.WriteLine();
Console.WriteLine(ShowNumbers1(30, 40));