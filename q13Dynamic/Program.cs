int[] arr = new int[10];
for (int i = 1; ; i++)
{
    Console.WriteLine("Enter a flight no: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Do you want to continue ? y/n");
    var yn = Console.ReadLine();
    if (yn == "n")
    {
        break;
    }
}

