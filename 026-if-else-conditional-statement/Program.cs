Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

//if (userChoice == "ABC")
//{
//    Console.WriteLine("User typed ABC");
//}
//else
//{
//    Console.WriteLine( "User did not type ABC");
//}

if (userChoice.Length <= 3)
{
    Console.WriteLine("Short answer");
}
// else is only checked if the condition for if has not been met
else if (userChoice.Length < 10 )
{
    Console.WriteLine("Medium answer");
}
else
{
    Console.WriteLine("Long answer");
}


Console.ReadKey();