// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.WriteLine("Enter the length of the array: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];
FillArray(array);
PrintArray(array);
Console.WriteLine($"The number of even numbers in the array: {Even(array)}");

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write($"{arr[arr.Length - 1]}");
        else Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"]");
}

int Even(int[] arr)
{
    int result = 0;
    foreach (var item in arr)
    {
        if (item % 2 == 0) result++;
    }
    return result;
}
