Console.WriteLine("Enter the fare: ");
double fare = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the time: ");
int time = Convert.ToInt32(Console.ReadLine());
if (time > 6 && time <= 9)
{
    fare = fare * 1.10;
    Console.WriteLine(fare);
}
else if (time > 9 && time <= 17)
{
    fare = fare * 1.20;
    Console.WriteLine(fare);
}
else if (time > 17 && time <= 23)
{
    fare = fare * 1.07;
    Console.WriteLine(fare);
}
else
{
    fare = fare * 1.05;
    Console.WriteLine(fare);
}