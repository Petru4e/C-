System.Console.WriteLine("Enter the number day of the week");
int day = Convert.ToInt32(Console.ReadLine());
string answer;
switch(day)
{
    case 1: answer="Monday"; break;
    case 2:answer="Tuesday "; break;
    case 3:answer="Wednesday "; break;
    case 4:answer="Thursday "; break;
    case 5:answer="Friday "; break;
    case 6:answer="Saturday "; break;
    case 7:answer="Sunday"; break;
    default: answer="There is no such day of the week";break;
}
System.Console.WriteLine(answer);