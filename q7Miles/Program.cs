string[] arr = new string[5];
int[] miles = new int[5];

Console.WriteLine("Enter the name of passengers: ");
for (int i = 0; i < 5; i++)
{
    arr[i] = Console.ReadLine();
}

Console.WriteLine("Enter the distance passengers covered: ");
for (int i = 0; i < 5; i++)
{
    miles[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("The flyer points rewarded for each passengers: \n");
for (int i = 0; i < 5; i++)
{
    if (miles[i] < 10000)
    {
        Console.WriteLine("no flyer points rewarded for " + arr[i]);
    }
    else if (miles[i] > 10000 && miles[i] < 20000)
    {
        Console.WriteLine(arr[i] + " got 10 flyer points");
    }
    else if (miles[i] > 20000 && miles[i] < 50000)
    {
        Console.WriteLine(arr[i] + " got 20 flyer points");
    }
    else if (miles[i] > 50000 && miles[i] < 100000)
    {
        Console.WriteLine(arr[i] + " got 30 flyer points");
    }
    else
    {
        Console.WriteLine(arr[i] + " got 50 flyer points");
    }
}

