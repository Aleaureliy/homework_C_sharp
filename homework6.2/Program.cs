// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] Promt(string message)
{
    double[] array = new double[4];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(message);
        array[i] = double.Parse(Console.ReadLine());
    }
    return array;
}

double[] IntersectionOfLines(double[] array)
{
    // b1, k1, b2 и k2
    // y = k1 * x + b1, y = k2 * x + b2; 
    // k2 * x + b2 = k1 * x + b1;
    // 9 * x + 4 = 5 * x + 2
    
    double[] result = new double[2];
    result[0] = (array[2] - array[0]) / (array[1] - array[3]);
    result[1] = array[1] * result[0] + array[0];
    return result;
}

double[] array = Promt("Ввод координат: ");
double[] result = IntersectionOfLines(array);
Console.WriteLine("Точка X: " + result[0]);
Console.WriteLine("Точка Y: " + result[1]);