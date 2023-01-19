Console.Write("Enter birth month: ");
int month = int.Parse(Console.ReadLine());

Console.Write("Enter birth date: ");
int day = int.Parse(Console.ReadLine());

Console.Write("Enter birth year: ");
int year = int.Parse(Console.ReadLine());

DateTime Date = new DateTime(year, month, day);
Console.WriteLine(Date); 

string CurrentYear = DateTime.Now.Year.ToString();
Console.WriteLine(CurrentYear +" is the current year."); 
Console.WriteLine("The age of passenger is: ");

int ydiff = Convert.ToInt32(CurrentYear) - year;
Console.WriteLine(ydiff +" years");

int months = ydiff * 12;
Console.WriteLine(months +" months");

int week = months * 5;
Console.WriteLine(week +" weeks"); 

int days = week * 7;
Console.WriteLine(days +" days");

int hours = days * 24; 
Console.WriteLine(hours +" hours");

if ((0 == year % 4) && (0 != year % 100) || (0 == year % 400))
{
    Console.WriteLine("year of birth is a leap year");
}
else
{
    Console.WriteLine("year of birth is not a leap year");
}