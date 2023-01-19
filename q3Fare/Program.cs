using System.Globalization;

double[] arr = new double[5];

Console.WriteLine("Enter the fares: ");
for (int i = 0; i < 5; i++)
{
    arr[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine("The values sorted in ascending order are: ");
for (int i = 0; i < 5; i++)
{
    for (int j = i + 1; j < 5; j++)
    {
        if (arr[i] > arr[j])
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(arr[i]);
}


Console.WriteLine("The values sorted in descending order are: ");
for (int i = 0; i < 5; i++)
{
    for (int j = i + 1; j < 5; j++)
    {
        if (arr[i] < arr[j])
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(arr[i]);
}


Console.WriteLine("Enter the fare to be searched: ");
double search = double.Parse(Console.ReadLine());
var flag = 0;

for (int i = 0; i < 5; i++)
{
    if (arr[i] == search)
    {
        flag = 1;
    }
}
if (flag == 1)
{
    Console.WriteLine("fare searched by you, is present here.");
}
else
{
    Console.WriteLine("fare searched by you, is not present here.");
}



for (int i = 0; i < 5; i++)
{
    for (int j = i + 1; j < 5; j++)
    {
        if (arr[i] == arr[j])
        {
            Console.WriteLine($"Duplicate of\" {arr[i]} \" is present");
        }
    }
}

var max = arr.Max();
Console.WriteLine($"The maximum fare is\" {max} \" in the array");

var min = arr.Min();
Console.WriteLine($"The maximum fare is\" {min} \" in the array");



