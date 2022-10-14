System.Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = -number; i <= number; i++)
{
    System.Console.Write(i + " ");
}
