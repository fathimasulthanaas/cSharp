double[] fare = new double[5];
string[] places = new string[5];
Console.WriteLine("Enter the fares: ");
for (int i = 0; i < 5; i++)
{
    fare[i] = double.Parse(Console.ReadLine());
}
Console.WriteLine("Enter the destinations: ");
for (int i = 0; i < 5; i++)
{
    places[i] = Console.ReadLine();
}

Console.WriteLine("Enter a number below 5: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(fare[num]);
Console.WriteLine(places[num]);


