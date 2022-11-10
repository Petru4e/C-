// Задача 29: Напишите программу,
// которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
using System.Diagnostics;
using System.Text;

Console.WriteLine("Enter the length of the array: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] array = new int[len];
FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
}

void PrintArray(int[] arr)
{
    #region StringBuilder
    Stopwatch watch1 = new Stopwatch();
    watch1.Start();//для проверки какой из вариантов работает быстрее

    StringBuilder builder = new StringBuilder();
    builder.Append("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        builder.Append($"{arr[i]}, ");
    }
    builder.Append($"{arr[arr.Length - 1]}]");
    Console.WriteLine(builder);

    watch1.Stop();
    Console.WriteLine(watch1.ElapsedMilliseconds);
    #endregion
    #region Array
    Stopwatch watch2 = new Stopwatch();
    watch2.Start();//для проверки какой из вариантов работает быстрее

    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");

    watch2.Stop();
    Console.WriteLine(watch2.ElapsedMilliseconds);
    #endregion
}