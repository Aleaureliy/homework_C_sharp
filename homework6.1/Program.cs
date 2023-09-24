// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int PositiveNumbers(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) count++;
//     }
//     return count;
// }

// int[] FillArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write("Введите число: ");
//         array[i] = int.Parse(Console.ReadLine());
//     }
//     return array;
// }

// Console.Write("Введите количество элементов массива:\t");
// int elementsCount = int.Parse(Console.ReadLine());
// int[] array = new int[elementsCount];
// FillArray(array);
// Console.Write("Положительных чисел: " + PositiveNumbers(array));

string[] WorkWithUser(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    string[] numbers = number.Split(", ");
    return numbers;
}

int[] StringToDigit(string[] array)
{
    int[] digits = new int[array.Length];
    for(int i = 0; i < digits.Length; i++)
    {
        digits[i] = int.Parse(array[i]);
    }
    return digits;
}

int PositiveNumbers1(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}

string[] numbers = WorkWithUser("Введите числа через запятую: ");
int[] collection = StringToDigit(numbers);
Console.WriteLine(PositiveNumbers1(collection));