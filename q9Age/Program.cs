
Console.WriteLine("Enter the date of birth of passenger : ");
DateTime date = DateTime.Parse(Console.ReadLine());
var temp = DateTime.Now.Year - date.Year;

//if (temp >= 0 && temp < 10)
//{
//    Console.WriteLine("The passenger is KID");
//}
//else if (temp >= 10 && temp < 30)
//{
//    Console.WriteLine("The passenger is YOUTH");
//}
//else if (temp >= 30 && temp < 60)
//{
//    Console.WriteLine("The passenger is ADULT");
//}
//else if (temp < 60)
//{
//    Console.WriteLine("The passenger is OLD");
//}
//else
//{
//    Console.WriteLine("");
//}

switch (temp)
{
    case >= 0 and < 10:
        Console.WriteLine("The passenger is kid");
        break;

    case >= 10 and < 30:
        Console.WriteLine("The passenger is youth");
        break;

    case >=30 and < 60:
        Console.WriteLine("The passenger is adult");
        break;

    case < 60:
        Console.WriteLine("The passenger is old");
        break;
}


