// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

string Day(int num)
{
    string result = "Нет";
    if (num > 5) result = "Да";
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