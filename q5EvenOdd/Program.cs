double[] arr = new double[6];
int n = arr.Length;
Console.WriteLine("Enter the fares: ");
for (int i = 0;i <arr.Length ; i++)
{
     arr[i] = double.Parse(Console.ReadLine());
}
int odd = 1;
int even = 0;
while (true)
{
    while (even < n && arr[even] % 2 == 0)
        even += 2;

    while (odd < n && arr[odd] % 2 == 1)
        odd += 2;

    if (even < n && odd < n)
    {
        double temp = arr[even];
        arr[even] = arr[odd];
        arr[odd] = temp;
    }

    else
        break;
}

Console.WriteLine("The fares are:");
for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i] + " ");







