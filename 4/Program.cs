/* Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве. */

int[] Massiv()
{
    int size = 6;
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void Print(int[] arr)
{
    Console.Write("[ ");
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("] --> ");
}

void Multiply (int[] arr)
{
    int size1 = arr.Length;
    int size2 = size1 / 2;
        
    Console.Write("[ ");

    for (int index = 0; index < size2; index++)
    {
        int mult = arr [index] * arr [size1 - 1 - index];
        Console.Write ($"{mult} ");
    }
    Console.WriteLine("]");
}

int[] arr_1 = Massiv();
Print(arr_1);
Multiply (arr_1);

int[] arr_2 = Massiv();
Print(arr_2);
Multiply (arr_2);

int[] arr_3 = Massiv();
Print(arr_3);
Multiply (arr_3);
