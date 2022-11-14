// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным 
//  и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


Console.WriteLine("Enter the length of the array: ");
int len = Convert.ToInt32(Console.ReadLine());

double[] array = new double[len];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Difference elements {MaxElement(array)} and {MinElement(array)} = {DifferenceElements(array)}");

void FillArray(double[] arr)
{
    double minRange = -100;
    double maxRange = 100;
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] =Math.Round((rnd.NextDouble() * (maxRange - minRange) + minRange), 1);
    }
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write($"{arr[arr.Length - 1]}");
        else Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"]");
}

double MaxElement(double[] arr)
{
    double max = arr[0];
    foreach (var item in arr)
    {
        if (max < item) max = item;
    }
    return max;
}

double MinElement(double[] arr)
{
    double min = arr[0];
    foreach (var item in arr)
    {
        if (min > item) min = item;
    }
    return min;
}

double DifferenceElements(double[] arr)
{
    return MaxElement(arr) - MinElement(arr);
}