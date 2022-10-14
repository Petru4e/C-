System.Console.WriteLine("Enter the number day of the week");
int day = Convert.ToInt32(Console.ReadLine());
switch(day)
{
    case 1:System.Console.WriteLine("Monday"); break;
    case 2:System.Console.WriteLine("Tuesday "); break;
    case 3:System.Console.WriteLine("Wednesday "); break;
    case 4:System.Console.WriteLine("Thursday "); break;
    case 5:System.Console.WriteLine("Friday "); break;
    case 6:System.Console.WriteLine("Saturday "); break;
    case 7:System.Console.WriteLine("Sunday"); break;
    default: System.Console.WriteLine("There is no such day of the week");break;
}