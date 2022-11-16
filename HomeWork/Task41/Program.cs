// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("How many numbers will you enter?");
int countNumber = Convert.ToInt32(Console.ReadLine());
int[] array = new int[countNumber];


//Вариант с вводом чисел по очереди через Enter
Console.WriteLine("After each number, press ENTER");
FillArray(array);
PrintArray(array);
Console.WriteLine($"Numbers greater than zero: {PositiveNumber(array)}");

// Вариант с вводом чисел через пробел
Console.WriteLine("let's try again");
Console.WriteLine("After each number, press SPACE");
FillArrayFromString(array);
PrintArray(array);
Console.WriteLine($"Numbers greater than zero: {PositiveNumber(array)}");


void FillArrayFromString(int[] arr)
{
    string [] numbers = Console.ReadLine()!.Split(' ');
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]=Convert.ToInt32(numbers[i]);
    }

}
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write($"[{arr[i]}, ");
        else if (i == arr.Length - 1) Console.WriteLine($"{arr[arr.Length - 1]}]");
        else Console.Write($"{arr[i]}, ");
    }
}
int PositiveNumber(int[] arr)
{
    int sumPositiveNumber=0;
    foreach (var item in arr)
    {
        if(item>0) sumPositiveNumber++;
    }
    return sumPositiveNumber;
}