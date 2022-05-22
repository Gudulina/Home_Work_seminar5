// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] Massiv()
{
    int size = 5;
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
    Console.Write("] ");
}

void Even(int[] arr)
{
    int size = arr.Length;
    int count = 0;
    Console.Write ("Сумма чисел на нечетных позициях: ");
    for (int i = 1; i < size; i += 2)
    {
        count = count + arr [i];        
    }
    Console.Write(count);
    Console.WriteLine();
}

int[] arr_1 = Massiv();
Print(arr_1);
Even(arr_1);

int[] arr_2 = Massiv();
Print(arr_2);
Even(arr_2);


int[] arr_3 = Massiv();
Print(arr_3);
Even(arr_3);
