string[] fare = new string[5];
string[] dest = new string[5];

Console.WriteLine("enter the fares: ");
for (int i = 0; i < 5; i++)
{
    fare[i] = Console.ReadLine();
}

Console.WriteLine("enter the destinations: ");
for (int i = 0; i < 5; i++)
{
    dest[i] = Console.ReadLine();
}

Console.WriteLine("the merged array is: ");
string[] arr = new string[fare.Length + dest.Length];
int j = 0;
for (int i = 0; i < fare.Length; i++)
{
    arr[j] = fare[i];
    arr[j + 1] = dest[i];
    j = j + 2;
}

//for (int i = 0;i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);  
//}
Console.WriteLine(string.Join(" , ", arr));

