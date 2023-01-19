 string[] names = new string[5];
Console.WriteLine("enter the names:");
for (int i = 0; i < names.Length; i++)
{

    names[i] = Console.ReadLine();
}

Array.Sort(names);
Console.WriteLine("The values sorted in ascending order are:");
foreach (string name in names)
{
    Console.WriteLine(name);
}




Array.Reverse(names);
Console.WriteLine("The values sorted in descending order are: ");
foreach (string name in names)
{
    Console.WriteLine(name);
}




Console.WriteLine("Enter the element to be searched:");
string search = Console.ReadLine();
int flag = 0;

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == search)
    {
        flag = 1;
    }
}
if (flag == 1)
{
    Console.WriteLine("present");
}
else
{
    Console.WriteLine("not found");
}




for (int i = 0; i < names.Length; i++)
{

    Console.WriteLine("the length of the name, " + names[i] + " is " + names[i].Length);

}




for (int i = 0; i < names.Length; i++)
{
    for (int j = i + 1; j < names.Length; j++)
    {
        if (names[j] == names[i])
        {
            Console.WriteLine("the duplicate of " + names[i] + " found");
        }
    }
}



foreach (var name in names)
{
    if (name.Contains(' '))
    {
        string[] nme = name.Split(' ');
        Console.WriteLine(string.Join("->", nme));
    }
}

