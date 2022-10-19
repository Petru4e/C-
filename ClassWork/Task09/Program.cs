int num = new Random().Next(10,100);
System.Console.WriteLine($"Сучайное число из диапазона 10-99-> {num}");

int firstDigit = num/10;
int secondDigit = num%10;
int max = firstDigit>secondDigit?firstDigit:secondDigit;
System.Console.WriteLine($" Наибольшая цифра числа {num} равна {max}");