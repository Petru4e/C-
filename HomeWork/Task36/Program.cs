// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Enter the length of the array: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Sum of elements not an even position: {SumElemEvenPos(array)}");

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10);
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

int SumElemEvenPos(int [] arr)
{
    int result=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i%2!=0) result+=arr[i];
    }
    return result;
}