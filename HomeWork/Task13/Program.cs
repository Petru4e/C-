// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int ThirdNumber(int num)
{
    int res = -1;
    num = Math.Abs(num);
    while (num % 1000 > 100)
    {
        res = num % 10;
        num = num / 10;
    }
    return res;
}

System.Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = ThirdNumber(number);
System.Console.WriteLine(result >= 0 ? result : "Третьей цифры нет");