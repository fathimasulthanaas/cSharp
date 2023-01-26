string[] pass = new string[10];
Console.WriteLine("Enter the Boarding Pass numbers:");
for (int i = 0; i < 10; i++)
{
    pass[i] = Console.ReadLine();
}

Queue<string> Queue1 = new Queue<string>(3);
Queue<string> Queue2 = new Queue<string>(3);
Queue<string> Queue3 = new Queue<string>(3);

Queue1.Enqueue(pass[0]);
Queue2.Enqueue(pass[1]);
Queue3.Enqueue(pass[2]);
Queue1.Enqueue(pass[3]);
Queue2.Enqueue(pass[4]);
Queue3.Enqueue(pass[5]);
Queue1.Enqueue(pass[6]);
Queue2.Enqueue(pass[7]);
Queue3.Enqueue(pass[8]);

Console.WriteLine("\nThe queue before a passenger left from counter:");
Console.WriteLine("\nCounter 1: ");
Console.WriteLine(string.Join(" ", Queue1));
Console.WriteLine("\nCounter 2");
Console.WriteLine(string.Join(" ", Queue2));
Console.WriteLine("\nCounter 3");
Console.WriteLine(string.Join(" ", Queue3));

Random rand = new Random();
int counter = rand.Next(2);
switch (counter)
{
    case 0:
        Queue1.Dequeue();
        Queue1.Enqueue(pass[9]);
        break;

    case 1:
        Queue2.Dequeue();
        Queue2.Enqueue(pass[9]);
        break;

    case 2:
        Queue3.Dequeue();
        Queue3.Enqueue(pass[9]);
        break;

    default:
        Console.WriteLine("Error");
        break;
}

Console.WriteLine("\nThe queue after a passenger exit from the counter: ");

Console.WriteLine("\nCounter 1: ");
Console.WriteLine(string.Join(" ", Queue1));

Console.WriteLine("\nCounter 2: ");
Console.WriteLine(string.Join(" ", Queue2));

Console.WriteLine("\nCounter 3: ");
Console.WriteLine(string.Join(" ", Queue3));


