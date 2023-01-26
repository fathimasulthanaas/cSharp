var arr = new string[5, 5]
{
    { "100A","101A","102A","103A","104A" },
    { "105B","106B","107B","108B","109B" },
    { "110C","111C","112C","113C","114C" },
    { "115D","116D","117D","118D","119D" },
    { "120E","121E","122E","123E","124E" }
};

int k = 1;
while (k <= 10)
{
Console.WriteLine("Enter the seat number:");
string seat = Console.ReadLine();
Console.WriteLine("Choose a or b :- (a)Veg (b)Non veg");
string pref = Console.ReadLine();

for (int i = 0; i < 5; i++)
{
for (int j = 0; j < 5; j++)
{
if ((arr[i, j] == seat) && (pref == "a"))
{
arr[i, j] = seat + " : " + "veg";
}
else if ((arr[i, j] == seat) && (pref == "b"))
{
arr[i, j] = seat + " : " + "non-veg";
}
}
}
k++;
}


for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(arr[i, j] + " \t");
    }
    Console.WriteLine();
}



//Dictionary<string, string> PassengerPreference = new Dictionary<string, string>();
//Console.WriteLine(@"1 :- Vegetarian
//2 :- Non - Vegetarian"); for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Enter the seat number for Passenger {0}", i + 1);
//    string SeatNumber = Console.ReadLine();
//    Console.WriteLine("Enter the food preference for Passenger {0}", i + 1);
//    string Preference = Console.ReadLine();
//    switch (Preference)
//    {
//        case "1":
//            Preference = "Veg";
//            break;
//        case "2":
//            Preference = "Non-Veg";
//            break;
//        default:
//            Preference = "Non-Veg";
//            break;
//    }
//    PassengerPreference.Add(SeatNumber, Preference);
//}
//string[,] SeatPattern = new string[5, 5] {
// {"100A", "100B", "100C", "100D", "100E"} ,
// {"101A", "101B", "101C", "101D", "101E"} ,
// {"102A", "102B", "102C", "102D", "102E"} ,
// {"103A", "103B", "103C", "103D", "103E"},
// { "104A", "104B", "104C", "104D", "104E" }
//};
//string[,] PreferenceBySeat = new string[5, 5]; for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        PreferenceBySeat[i, j] = "TBC";
//    }
//}
//for (int k = 0; k < 5; k++)
//{
//    for (int i = 0; i < 5; i++)
//    {
//        for (int j = 0; j < 5; j++)
//        {
//            if (PassengerPreference.ElementAt(k).Key == SeatPattern[i, j])
//                PreferenceBySeat[i, j] = PassengerPreference.ElementAt(k).Value;
//        }
//    }
//}
//Console.WriteLine("Preference By Seat Number (Front Row to Last Row): ");
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Console.Write(PreferenceBySeat[i, j] + "\t");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("Preference By Seat Number (Last Row to Front Row): ");
//for (int i = 4; i >= 0; i--)
//{
//    for (int j = 0; j < 5; j++)
//    {
//        Console.Write(PreferenceBySeat[i, j] + "\t");
//    }
//    Console.WriteLine();
//}

