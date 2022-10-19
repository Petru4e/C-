//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1
int SecondNumber(int num)
{
    return num/10%10;
}

int number;
do
{
    System.Console.WriteLine("Введите трехзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
while (number / 1000 != 0 || Math.Abs(number % 1000) < 100);

int secondNum=SecondNumber(number);
System.Console.WriteLine($"Вторая цифра числа {number} равна: {secondNum}");