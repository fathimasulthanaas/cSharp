int[] weight = new int[5];
Console.WriteLine("Enter the weights: ");
for (int i = 0; i < weight.Length; i++)
{
    weight[i] = Convert.ToInt32(Console.ReadLine());
    if (weight[i] > 23)
    {
        int add_wt = weight[i] - 23;
        weight[i] = add_wt * 15;
        Console.WriteLine($"there is {add_wt} kgs overweight and it costs an additional fare of {weight[i]} Rs.");
    }
    else
    {
        Console.WriteLine("The weight is under the terms & conditions.");
    }
}

for (int i = 0; i < weight.Length; i++)
{
    for (int j = i + 1; j < weight.Length; j++)
    {
        if (weight[i] > weight[j])
        {
            int temp = weight[i];
            weight[i] = weight[j];
            weight[j] = temp;
        }
    }
}

Console.WriteLine("\nThe sorted weights are: ");
Console.WriteLine(string.Join(" , ", weight));
