
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

bool Polydrome(int num)
{
    int original = num;
    int invertedNumber = 0;
    while (num > 0)
    {
        invertedNumber = invertedNumber * 10 + num % 10;
        num = num / 10;
    }
    return original == invertedNumber;
}

int number;
do
{
    System.Console.WriteLine("Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
while (number / 100000 != 0 || Math.Abs(number % 100000) < 10000);


System.Console.WriteLine(Polydrome(number)? "да":"нет");