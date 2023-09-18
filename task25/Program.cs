// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

int[] multiplication(int[] array)
{
    int size;
    if(array.Length % 2 == 0) size = array.Length/2;
    else size = array.Length/2 + 1;
    int[] newArray = new int[size];
    for(int i = 0; i < newArray.Length; i++)
    {
        if(array.Length % 2 == 1 && i == newArray.Length - 1) newArray[i] = array[i]; // Для последнего эллемента
        else newArray[i] = array[i] * array[array.Length - i -1];
    }
    return newArray;
}

int[] arr = new int[]{1, 2, 3, 4, 5};
int [] newArray = multiplication(arr);
Console.WriteLine(string.Join(" ", newArray));