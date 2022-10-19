// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool Day(int num)
{
    bool result = false;
    if (num > 5) result = true;
    return result;
}

int number;
do
{
    System.Console.Write("Введите число от 1 до 7: ");
    number = Convert.ToInt32(Console.ReadLine());
}
while (number > 7 || number < 1);

System.Console.WriteLine($"Этот день выходной: {Day(number)}");