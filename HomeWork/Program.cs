// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter first number: ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int num2=Convert.ToInt32(Console.ReadLine());
int max = num1>num2?num1:num2;
System.Console.WriteLine("Max = {0}", max);

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter first number: ");
int number1=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int number2=Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int number3=Convert.ToInt32(Console.ReadLine());
int maximum = number1;
if(number2>max&&number3<number2) maximum=number2;
else if(number3>max) maximum=number3;
System.Console.WriteLine($"Max = {maximum}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Enter number: ");
int num=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(num%2==0? "Число четное":"Число нечетное");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.Write("Enter a natural number: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= number; i++)
{
    if (i%2==0) Console.Write($"{i} ");
}