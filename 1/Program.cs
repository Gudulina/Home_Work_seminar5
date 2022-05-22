// Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] Massiv()
{
    int size = 5;
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100, 1000);
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
    int Remain = -1;
    int count = 0;

    Console.Write("Четных чисел: ");    
    for (int i = 0; i < size; i++)
    {
        Remain = arr[i] % 2;
        if (Remain == 0)
            count += 1;        
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