// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void Table(int num)
{
    System.Console.WriteLine($"Number|   Cube");
    for (int i = 1; i <= num; i++)
    {
        System.Console.WriteLine($"{i,4}  | {Math.Pow(i,3),8}");
    }
}

System.Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
Table(number);
