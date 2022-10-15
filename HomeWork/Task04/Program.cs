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
if(number2>maximum) maximum=number2;
if(number3>=maximum) maximum=number3;
System.Console.WriteLine($"Max = {maximum}");