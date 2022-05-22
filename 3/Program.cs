// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] Massiv()
{
    int size = 5;
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
    Console.Write(arr);
}

void Print(double[] arr)
{
    Console.Write("[ ");
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("] ");
}

void MinMax(double[] arr)
{
    int size = arr.Length;
    int index = 0;
    double Min = arr[index];
    double Max = arr[index];
    double Diff = 0;
    
    for (int index = 0; index < size; index++)
    {
        if (arr[index] < Min)
            Min = arr[index];
        if (arr[index] > Max)
            Max = arr[index];
        Diff = Max - Min;
        Console.WriteLine($"Разница между Max и Min: {Diff}");
    }
}

double[] arr_1 = Massiv();
Print(arr_1);
MinMax(arr_1);

double[] arr_2 = Massiv();
Print(arr_2);
MinMax(arr_2);

double[] arr_3 = Massiv();
Print(arr_3);
MinMax(arr_3);
