// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter first number: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int num2=Convert.ToInt32(Console.ReadLine());
int max = num1>num2?num1:num2;
System.Console.WriteLine("Max = {0}", max);6